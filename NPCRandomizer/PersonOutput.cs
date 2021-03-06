﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NPCRandomizer {
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    
    public partial class PersonOutput : PersonOutputBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 7 ""
            this.Write(@"<html>
<head>
	<title>NPCs</title>
	<link href=""person.css"" rel=""stylesheet"">
    <style>
    body
{
    background: #bbb;
}

.person, h1 {
    background-color: white;
    box-shadow: 4px 4px 2px rgba(0,0,0,.4);
}

.container {
    width: 80%;
    margin-left: 10%;
    display: grid;
    grid-template-columns: repeat(6, 1fr);
    grid-gap: 8px;
    background-color: transparent;
}

h1 {
    text-align: center;
    grid-column: 1/7;
    height: 2em;
    padding: 4px;
    margin: 0px;
}

.row {
    border-bottom: 1px solid black;
}

.person > div {
    padding: 4px;
}
    </style>
</head>
<body>
<div class=""container"">
<h1>Generated NPCs for the ");
            
            #line default
            #line hidden
            
            #line 50 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( Nation ));
            
            #line default
            #line hidden
            
            #line 50 ""
            this.Write("</h1>\n");
            
            #line default
            #line hidden
            
            #line 51 ""
 foreach (PersonData npc in People) { 
            
            #line default
            #line hidden
            
            #line 52 ""
            this.Write("\t<div class=\"person\">\n\t\t<div class=\"row\"><b>");
            
            #line default
            #line hidden
            
            #line 53 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( npc.Name ));
            
            #line default
            #line hidden
            
            #line 53 ""
            this.Write("</b></div>\n\t\t<div class=\"row\">");
            
            #line default
            #line hidden
            
            #line 54 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( npc.Age ));
            
            #line default
            #line hidden
            
            #line 54 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 54 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( npc.Gender ));
            
            #line default
            #line hidden
            
            #line 54 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 54 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( npc.Race ));
            
            #line default
            #line hidden
            
            #line 54 ""
            this.Write(" ");
            
            #line default
            #line hidden
            
            #line 54 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( npc.Subrace != ""? "(" + npc.Subrace + ")" : "" ));
            
            #line default
            #line hidden
            
            #line 54 ""
            this.Write(" </div>\n\t\t<div class=\"row\">Religiosity: ");
            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( npc.Religion ));
            
            #line default
            #line hidden
            
            #line 55 ""
            this.Write("</div>\n\t\t<div class=\"row\">Profession: ");
            
            #line default
            #line hidden
            
            #line 56 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( npc.Profession ));
            
            #line default
            #line hidden
            
            #line 56 ""
            this.Write("</div>\n\t\t<div>Personality: ");
            
            #line default
            #line hidden
            
            #line 57 ""
            this.Write(this.ToStringHelper.ToStringWithCulture( npc.Personality ));
            
            #line default
            #line hidden
            
            #line 57 ""
            this.Write("</div>\n\t</div>\n");
            
            #line default
            #line hidden
            
            #line 59 ""
 } 
            
            #line default
            #line hidden
            
            #line 60 ""
            this.Write("</div>\n</body>\n</html>\n\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class PersonOutputBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
