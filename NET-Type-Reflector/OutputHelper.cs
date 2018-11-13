using System;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using Extensions;

namespace NetTypeReflector
{
    internal static class OutputHelper
    {
        public static void AddSection(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(106, 153, 85));
        }

        public static void AddTypeName(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(78, 201, 162));
        }

        public static void AddInfo(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(220, 220, 220));
        }

        private static void AddMethodName(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(220, 220, 156));
        }

        private static void AddPunctuation(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(212, 212, 212));
        }

        private static void AddParameterName(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(212, 212, 212));
        }

        private static void AddModifier(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(86, 156, 214));
        }

        private static void AddParameterInfo(RichTextBox box, ParameterInfo[] parameters, bool multiline, bool isExtension)
        {
            AddPunctuation(box, "(" + (multiline && parameters.Length > 0 ? "\n" : ""));

            for (var i = 0; i < parameters.Length; i++)
            {
                AddInfo(box, (multiline ? "    " : "")
                    + (i == 0 && isExtension ? "this " : ""));
                AddTypeName(box, parameters[i].ParameterType.ToString());
                box.AppendText(" ");
                AddParameterName(box, parameters[i].Name);
                if (i < parameters.Length - 1)
                {
                    AddPunctuation(box, "," + (multiline ? "\n" : " "));
                }
                else
                {
                    AddInfo(box, (multiline ? "\n" : ""));
                }
            }

            AddPunctuation(box, ");");
            box.AppendText("\n");
        }

        public static void AddConstructorInfo(RichTextBox box, ConstructorInfo ci)
        {
            var position = box.Text.Length;

            AddConstructorInfoDescription(box, ci);
            AddParameterInfo(box, ci.GetParameters(), false, false);
        }

        public static void ShowConstructorDetails(RichTextBox box, ConstructorInfo ci)
        {
            AddConstructorInfoDescription(box, ci);
            AddParameterInfo(box, ci.GetParameters(), true, false);
        }

        private static void AddConstructorInfoDescription(RichTextBox box, ConstructorInfo ci)
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
        }

        public static void AddMethodInfo(RichTextBox box, MethodInfo mi, Type t, bool isExtension)
        {
            AddMethodInfoDescription(box, mi, t);
            AddParameterInfo(box, mi.GetParameters(), false, isExtension);
        }

        public static void ShowMethodDetails(RichTextBox box, MethodBase mi, Type t, bool isExtension)
        {
            AddMethodInfoDescription(box, (MethodInfo)mi, t);
            AddParameterInfo(box, mi.GetParameters(), true, isExtension);
        }

        private static void AddMethodInfoDescription(RichTextBox box, MethodInfo mi, Type t)
        {
            var position = box.Text.Length;

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
        }

        public static void AddPropertyInfo(RichTextBox box, PropertyInfo pi)
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
    }
}