using System;
using System.Reflection;
using System.Windows.Forms;
using System.Drawing;
using Extensions;
using System.Text.RegularExpressions;

namespace NetTypeReflector
{
    internal static class OutputHelper
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
            var re = new Regex(@"`.+\[(.+)\]");

            var result = re.Replace(typeName, "<$1>").ToString();            
            
            return result;
        }

        private static string TypeToKeyword(Type t)
        {
            switch (t.Name)
            {
                case "Boolean":
                    return "bool";
                case "Byte":
                    return "byte";
                case "SByte":
                    return "sbyte";
                case "Char":
                    return "char";
                case "Decimal":
                    return "decimal";
                case "Double":
                    return "double";
                case "Single":
                    return "float";
                case "Int32":
                    return "int";
                case "UInt32":
                    return "uint";
                case "Int64":
                    return "long";
                case "UInt64":
                    return "ulong";
                case "Object":
                    return "object";
                case "Int16":
                    return "short";
                case "UInt16":
                    return "ushort";
                case "String":
                    return "string";
                case "Void":
                    return "void";
                default:
                    return t.Name;
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

                bool isKeywordType = false;

                if (KeywordTypeNames)
                {
                    var keyword = TypeToKeyword(parameters[i].ParameterType);

                    if (keyword != parameters[i].ParameterType.Name)
                    {
                        AddKeyWord(box, keyword);
                        isKeywordType = true;
                    }
                }
                
                if (!KeywordTypeNames || !isKeywordType)
                {
                    AddTypeName(box,
                        FormatGenericType(FullQualifiedTypeNames ?
                            parameters[i].ParameterType.FullName :
                            parameters[i].ParameterType.Name )
                    );
                }

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

            bool isKeywordType = false;

            if (KeywordTypeNames)
            {
                var keyword = TypeToKeyword(mi.ReturnType);

                if (keyword != mi.ReturnType.Name)
                {
                    AddKeyWord(box, keyword);
                    isKeywordType = true;
                }
            }
            
            if (!KeywordTypeNames || !isKeywordType)
            {
                AddTypeName(box,
                    FormatGenericType(FullQualifiedTypeNames ?
                        mi.ReturnType.FullName :
                        mi.ReturnType.Name )
                );
            }

            AddMethodName(box, " " + mi.Name);
        }

        public static void AddPropertyInfo(RichTextBox box, PropertyInfo pi)
        {
            AddInfo(box, "• ");
            AddKeyWord(box,
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