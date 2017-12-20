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
            DisplayInfo();
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

        #endregion


        #region Helper methods

        private void DisplayInfo()
        {
            if (txtTypeName.Text == String.Empty)
            {
                return;
            }

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
                richtxtInfo.Text = TypeInfo(t, CombineBindingFlags());
            }
            else
            {
                MessageBox.Show("Specified type not found.");
                return;
            }
        }

        private string TypeInfo(Type t, BindingFlags flags)
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Type:");
            info.AppendLine(t.FullName);

            if (t.IsSealed)
            {
                info.AppendLine("[sealed]");
            }

            info.AppendLine("\nAssembly:");
            info.AppendLine(t.Assembly.FullName);
            info.AppendLine(t.Assembly.Location);

            info.AppendLine("\nAttributes:");
            info.AppendLine(t.Attributes.ToString());

            info.AppendLine("\nCustom Attributes:");
            foreach(var ca in t.CustomAttributes)
            {
                info.AppendLine(ca.ToString());
            }

            info.AppendLine("\nBase Type:");
            info.AppendLine(t.BaseType != null ? t.BaseType.FullName : "No base type");

            info.AppendLine("\nInterfaces:");
            Type[] interfaces = t.GetInterfaces();
            foreach (Type i in interfaces)
            {
                info.AppendLine(i.FullName);
            }

            info.AppendLine("\n-------------------------------------------------");

            info.AppendLine("\nConstructors:");
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo ci in constructors)
            {
                info.AppendLine(ci.ToString());
            }


            info.AppendLine("\nMethods:");
            MethodInfo[] methods = t.GetMethods(flags);
            StringBuilder tmp = new StringBuilder();
            foreach (MethodInfo mi in methods)
            {
                tmp.Clear();

                if (mi.DeclaringType != t)
                {
                    tmp.Append("▲ ");
                }

                //
                if (mi.IsPublic)
                {
                    tmp.Append("public");
                }
                else if (mi.IsPrivate)
                {
                    tmp.Append("private");
                }
                else
                {
                    tmp.Append("protected");
                }

                if (mi.IsStatic)
                {
                    tmp.Append(" static");
                }

                //
                if (mi.IsVirtual)
                {
                    tmp.Append(" virtual");
                }

                tmp.Append(" ");

                info.Append(tmp.ToString());
                info.AppendLine(mi.ToString());
            }

            info.AppendLine("\nProperties:");
            PropertyInfo[] properties = t.GetProperties(flags);
            foreach (PropertyInfo pi in properties)
            {
                info.AppendLine("* " + pi.DeclaringType + " " + pi.Name
                    + " { " + (pi.CanRead ? "get; " : "") + (pi.CanWrite ? "set " : "") + "}");
            }


            return info.ToString();
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

        //private void ShowTypes(string assemblyFilePath)
        //{
        //    try
        //    {
        //        lstTypes.Items.Clear();

        //        Assembly a = Assembly.LoadFile(assemblyFilePath);
        //        foreach(TypeInfo ti in a.DefinedTypes)
        //        {
        //            lstTypes.Items.Add(ti.FullName);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(String.Format("An error occured:\n{0}", e.ToString()));
        //    }
        //}

        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
