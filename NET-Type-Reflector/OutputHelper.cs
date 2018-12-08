using System;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using Extensions;
using System.Text.RegularExpressions;

namespace NetTypeReflector
{
    internal static partial class OutputHelper
    {
        #region Properties

        public static bool FullQualifiedTypeNames { get; set; }
        public static bool KeywordTypeNames { get; set; }

        #endregion


        #region Constructor

        static OutputHelper()
        {
            FullQualifiedTypeNames = false;
            KeywordTypeNames = true;
        }

        #endregion

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

        private static void AddKeyWord(RichTextBox box, string s)
        {
            box.AppendText(s, Color.FromArgb(86, 156, 214));
        }

        private static string FormatGenericType(string typeName)
        {
            var re = new Regex(@"`.*?(\[)");

            var result = re.Replace(typeName, "$1").ToString();
            result = result.Replace("[]", "##");
            result = result.Replace("[", "<")
			    .Replace("]", ">")
                .Replace("##", "[]");
            
            return result;
        }

        private static void AddTypeName(RichTextBox box, Type t)
        {
            // To do. TODO.
            // Implement more smart logic.

            bool isKeywordType = false;

            if (KeywordTypeNames)
            {
                var keyword = TypeToKeyword(t);

                if (keyword != t.Name)
                {
                    AddKeyWord(box, keyword);
                    isKeywordType = true;
                }
            }
            
            if (!KeywordTypeNames || !isKeywordType)
            {
                if (FullQualifiedTypeNames)
                {
                    AddTypeName(box, FormatGenericType(t.ToString()));
                }
                else
                {
                    var tmp = t.ToString();
                    var start = -1;
                    var bracketIndex = tmp.IndexOf("[");
                    
                    if (bracketIndex >= 0)
                    {
                        start = tmp.LastIndexOf(".", bracketIndex);
                    }
                    else
                    {
                        start = tmp.LastIndexOf(".");
                    }

                    AddTypeName(box, FormatGenericType(start >= 0 ? tmp.Substring(start + 1) : tmp));
                }
            }
        }

        private static void AddParameterInfo(RichTextBox box, ParameterInfo[] parameters, bool multiline, bool isExtension)
        {
            AddPunctuation(box, "(" + (multiline && parameters.Length > 0 ? "\n" : ""));

            for (var i = 0; i < parameters.Length; i++)
            {
                AddKeyWord(box, (multiline ? "    " : "")
                    + (i == 0 && isExtension ? "this " : ""));

                AddKeyWord(box, parameters[i].IsIn ? "in " : "");
                AddKeyWord(box, parameters[i].IsOut ? "out " : "");
                AddKeyWord(box, parameters[i].ParameterType.IsByRef && !parameters[i].IsOut ? "ref " : "");

                AddTypeName(box, parameters[i].ParameterType);
                
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
                AddKeyWord(box, "private");
            }
            else if (ci.IsPublic)
            {
                AddKeyWord(box, "public");
            }
            else if (ci.IsFamily)
            {
                AddKeyWord(box, "protected");
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

            if (!mi.IsPrivate && !mi.IsPublic && !mi.IsFamily)
            {
                AddInfo(box, "* ");
            }

            //
            if (mi.IsPublic)
            {
                AddKeyWord(box, "public");
            }
            else if (mi.IsPrivate)
            {
                AddKeyWord(box, "private");
            }
            else
            {
                AddKeyWord(box, "protected");
            }

            if (mi.IsStatic)
            {
                AddKeyWord(box, " static");
            }

            //
            if (mi.IsVirtual)
            {
                AddKeyWord(box, " virtual");
            }

            box.AppendText(" ");

            AddTypeName(box, mi.ReturnType);

            AddMethodName(box, " " + mi.Name);
        }

        public static void AddPropertyInfo(RichTextBox box, PropertyInfo pi)
        {
            AddInfo(box, "• ");
            AddKeyWord(box,
                (pi.GetMethod != null) && pi.GetMethod.IsPrivate && (pi.SetMethod != null) && pi.SetMethod.IsPrivate
                    ? "private" : "public");
            AddInfo(box, " ");
            AddTypeName(box, pi.PropertyType);
            AddMethodName(box, " " + pi.Name);
            AddPunctuation(box, " { ");
            AddInfo(box, pi.CanRead ? "get; " : "");
            AddInfo(box, pi.CanWrite ? "set " : "");
            AddPunctuation(box, "}");
        }
    }
}