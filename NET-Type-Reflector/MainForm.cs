using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.Threading;
using Extensions;
using System.Drawing;
using System.Windows.Forms;

namespace ReflectorTRM
{
    public partial class MainForm : Form
    {
        #region Fields

        private List<string> m_AssemblyTypes = new List<string>();
        private OpenFileDialog m_OpenFileDialog = null;

        #endregion


        #region Constructors

        public MainForm()
        {
            InitializeComponent();

            comboInstanceStatic.SelectedIndex = 0;
            comboVisibility.SelectedIndex = 0;
        }

        #endregion


        #region Form's events handlers

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            DisplayInfo();
        }

        private void btnSelectAssembly_Click(object sender, EventArgs e)
        {
            if (m_OpenFileDialog == null)
            {
                m_OpenFileDialog = new OpenFileDialog();
            }

            DialogResult result = m_OpenFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            txtAssemblyPath.Text = m_OpenFileDialog.FileName;

            if (LoadTypes(txtAssemblyPath.Text))
            {
                ShowTypes();
            }
            else
            {
                MessageBox.Show("No types found in\n" + txtAssemblyPath.Text);
            }
        }

        private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTypeName.Text = lstbxTypes.SelectedItem.ToString();
        }

        private void lstbxTypes_DoubleClick(object sender, EventArgs e)
        {
            if (lstbxTypes.SelectedIndex >= 0)
            {
                txtTypeName.Text = lstbxTypes.SelectedItem.ToString();
                DisplayInfo();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ShowTypes();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            ShowTypes();
        }

        private void chkWrapLines_CheckedChanged(object sender, EventArgs e)
        {
            richtxtInfo.WordWrap = chkWrapLines.Checked;
        }

        private void txtAssemblyPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (LoadTypes(txtAssemblyPath.Text))
                {
                    ShowTypes();
                }
                else
                {
                    MessageBox.Show("No types found in\n" + txtAssemblyPath.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion


        #region Helper methods

        private void DisplayInfo()
        {
            if (txtTypeName.Text == String.Empty)
            {
                return;
            }

            richtxtInfo.Clear();

            txtTypeName.Text = txtTypeName.Text.Trim();

            Type t = Type.GetType(txtTypeName.Text);

            if (t == null)
            {
                try
                {
                    t = Assembly.LoadFile(txtAssemblyPath.Text).GetType(txtTypeName.Text);
                }
                catch
                { }
            }

            if (t != null)
            {
                TypeInfo(richtxtInfo, t, CombineBindingFlags());
            }
            else
            {
                MessageBox.Show("Specified type not found.");
                return;
            }
        }

        private void TypeInfo(RichTextBox box, Type t, BindingFlags flags)
        {
            AddSection(box, "Type:\n");
            AddTypeName(box, t.FullName + "\n");

            if (t.IsSealed)
            {
                AddInfo(box, "[sealed]\n");
            }

            AddSection(box, "\nAssembly:\n");
            AddInfo(box, t.Assembly.FullName + "\n");
            AddInfo(box, t.Assembly.Location + "\n");

            AddSection(box, "\nAttributes:\n");
            AddInfo(box, t.Attributes.ToString() + "\n");

            AddSection(box, "\nCustom Attributes:\n");
            foreach(var ca in t.CustomAttributes)
            {
                AddInfo(box, ca.ToString() + "\n");
            }

            AddSection(box, "\nBase Type:\n");
            AddTypeName(box, (t.BaseType != null ? t.BaseType.FullName : "No base type") + "\n");

            AddSection(box, "\nInterfaces:\n");
            Type[] interfaces = t.GetInterfaces();
            if (interfaces.Length > 0)
            {
                foreach (Type i in interfaces)
                {
                    AddTypeName(box, i.FullName + "\n");
                }
            }
            else
            {
                AddInfo(box, "-\n");
            }

            AddSection(box, "\n-------------------------------------------------\n");

            AddSection(box, "\nConstructors:\n");
            ConstructorInfo[] constructors = t.GetConstructors();
            if (constructors.Length > 0)
            {
                foreach (ConstructorInfo ci in constructors)
                {
                    AddConstructorInfo(box, ci);
                }
            }
            else
            {
                AddInfo(box, "-\n");
            }


            AddSection(box, "\nMethods:\n");
            MethodInfo[] methods = t.GetMethods(flags);
            if (methods.Length > 0)
            {
                Array.Sort(methods, (m1, m2) => {
                    // Methods declared in parent go first.
                    if (m1.DeclaringType != m2.DeclaringType)
                    {
                        if (m1.DeclaringType == t)
                        {
                            return 1;
                        }
                        else if (m2.DeclaringType == t)
                        {
                            return -1;
                        }
                        // Something weird...
                        else
                        {
                            return 0;
                        }
                    }
                    // Then sorting methods by name.
                    else
                    {
                        return m1.Name.CompareTo(m2.Name);
                    }
                });
                foreach (MethodInfo mi in methods)
                {
                    AddMethodInfo(box, mi, t);
                }
            }
            else
            {
                AddInfo(box, "-\n");
            }

            AddSection(box, "\nProperties:\n");
            PropertyInfo[] properties = t.GetProperties(flags);
            if (properties.Length > 0)
            {
                foreach (PropertyInfo pi in properties)
                {
                    AddPropertyInfo(box, pi);
                    box.AppendText("\n");
                }
            }
            else
            {
                AddInfo(box, "-\n");
            }

            if (t.IsEnum)
            {
                AddSection(box, "\nEnum values:\n");
                var values = Enum.GetValues(t);
                foreach (var v in values)
                {
                    var name = Enum.GetName(t, v);
                    AddInfo(box, name + ": " + ((int)v).ToString() + "\n");
                }
            }
        }

        private BindingFlags CombineBindingFlags()
        {
            BindingFlags flags = new BindingFlags();

            if ((string)comboInstanceStatic.SelectedItem == "Both")
            {
                flags |= BindingFlags.Instance | BindingFlags.Static;
            }
            else if ((string)comboInstanceStatic.SelectedItem == "Instance")
            {
                flags |= BindingFlags.Instance;
            }
            else if ((string)comboInstanceStatic.SelectedItem == "Static")
            {
                flags |= BindingFlags.Static;
            }

            if ((string)comboVisibility.SelectedItem == "Both")
            {
                flags |= BindingFlags.Public | BindingFlags.NonPublic;
            }
            else if ((string)comboVisibility.SelectedItem == "Public")
            {
                flags |= BindingFlags.Public;
            }
            else if ((string)comboVisibility.SelectedItem == "NonPublic")
            {
                flags |= BindingFlags.NonPublic;
            }

            if (chkDeclaredOnly.Checked)
            {
                flags |= BindingFlags.DeclaredOnly;
            }

            if (chkFlattenHierarchy.Checked)
            {
                flags |= BindingFlags.FlattenHierarchy;
            }

            return flags;
        }

        private bool LoadTypes(string assemblyFilePath)
        {
            try
            {
                m_AssemblyTypes.Clear();

                Assembly a = Assembly.LoadFile(assemblyFilePath);

                foreach (TypeInfo ti in a.DefinedTypes)
                {
                    m_AssemblyTypes.Add(ti.FullName);
                }

                return true;
            }
            catch (Exception e)
            {
                lstbxTypes.Items.Clear();
                lstbxTypes.Text = "... / ...";
                MessageBox.Show(String.Format("An error occured:\n{0}", e.ToString()));
                return false;
            }
        }

        private void ShowTypes()
        {
            lstbxTypes.Items.Clear();
            foreach (string type in m_AssemblyTypes)
            {
                if ((txtFilter.Text == "") || (txtFilter.Text != "" && type.Contains(txtFilter.Text)))
                {
                    lstbxTypes.Items.Add(type);
                }
            }

            lblCount.Text = (txtFilter.Text != "" ? lstbxTypes.Items.Count.ToString() + " of " : "")
                + m_AssemblyTypes.Count.ToString() + " types";
        }

        private void AddSection(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(100, 100, 100));
        }

        private void AddTypeName(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(78, 201, 162));
        }

        private void AddInfo(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(220, 220, 220));
        }

        private void AddMethodName(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(220, 220, 156));
        }

        private void AddPunctuation(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(212, 212, 212));
        }

        private void AddParameterName(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(212, 212, 212));
        }

        private void AddModifier(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(86, 156, 214));
        }

        private void AppParameterInfo(RichTextBox box, ParameterInfo[] parameters)
        {
            AddPunctuation(box, "(");

            for (var i = 0; i < parameters.Length; i++)
            {
                AddTypeName(box, parameters[i].ParameterType.ToString());
                box.AppendText(" ");
                AddParameterName(box, parameters[i].Name);
                if (i < parameters.Length - 1)
                {
                    AddPunctuation(box, ", ");
                }
            }

            AddPunctuation(box, ")");
            box.AppendText("\n");
        }

        private void AddConstructorInfo(RichTextBox box, ConstructorInfo ci)
        {
            if (ci.IsPrivate)
            {
                AddModifier(box, "private");
            }
            else if (ci.IsPublic)
            {
                AddModifier(box, "public");
            }
            else if (ci.IsFamily)
            {
                AddModifier(box, "protected");
            }

            box.AppendText(" ");

            AddMethodName(box, ci.Name);
            AppParameterInfo(box, ci.GetParameters());
        }

        private void AddMethodInfo(RichTextBox box, MethodInfo mi, Type t)
        {
            if (mi.DeclaringType != t)
            {
                AddInfo(box, "▲ ");
            }

            //
            if (mi.IsPublic)
            {
                AddModifier(box, "public");
            }
            else if (mi.IsPrivate)
            {
                AddModifier(box, "private");
            }
            else
            {
                AddModifier(box, "protected");
            }

            if (mi.IsStatic)
            {
                AddModifier(box, " static");
            }

            //
            if (mi.IsVirtual)
            {
                AddModifier(box, " virtual");
            }

            box.AppendText(" ");

            AddTypeName(box, mi.ReturnType.ToString());
            AddMethodName(box, " " + mi.Name);
            AppParameterInfo(box, mi.GetParameters());
        }

        private void AddPropertyInfo(RichTextBox box, PropertyInfo pi)
        {
            AddInfo(box, "• ");
            AddModifier(box,
                (pi.GetMethod != null) && pi.GetMethod.IsPrivate && (pi.SetMethod != null) && pi.SetMethod.IsPrivate
                    ? "private" : "public");
            AddTypeName(box, " " + pi.PropertyType);
            AddMethodName(box, " " + pi.Name);
            AddPunctuation(box, " { ");
            AddInfo(box, pi.CanRead ? "get; " : "");
            AddInfo(box, pi.CanWrite ? "set " : "");
            AddPunctuation(box, "}");
        }

        #endregion
    }
}
