﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.lantanagroup.com/voc")]
[System.Xml.Serialization.XmlRootAttribute(ElementName = "systems", Namespace = "http://www.lantanagroup.com/voc", IsNullable = false)]
public partial class VocabularySystems {
    
    private VocabularySystem[] systemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("system")]
    public VocabularySystem[] Systems {
        get {
            return this.systemField;
        }
        set {
            this.systemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.lantanagroup.com/voc")]
[System.Xml.Serialization.XmlRootAttribute(ElementName="system", Namespace="http://www.lantanagroup.com/voc", IsNullable=false)]
public partial class VocabularySystem {
    
    private VocabularyCode[] codeField;
    
    private string valueSetOidField;
    
    private string valueSetNameField;
    
    private string rootField;
    
    private string codeSystemNameField;
    
    private string bindingField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("code")]
    public VocabularyCode[] Codes {
        get {
            return this.codeField;
        }
        set {
            this.codeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "valueSetOid")]
    public string ValueSetOid {
        get {
            return this.valueSetOidField;
        }
        set {
            this.valueSetOidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "valueSetName")]
    public string ValueSetName {
        get {
            return this.valueSetNameField;
        }
        set {
            this.valueSetNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "root")]
    public string Root {
        get {
            return this.rootField;
        }
        set {
            this.rootField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "codeSystemName")]
    public string CodeSystemName {
        get {
            return this.codeSystemNameField;
        }
        set {
            this.codeSystemNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName="binding")]
    public string Binding {
        get {
            return this.bindingField;
        }
        set {
            this.bindingField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.lantanagroup.com/voc")]
[System.Xml.Serialization.XmlRootAttribute(ElementName="code", Namespace="http://www.lantanagroup.com/voc", IsNullable=false)]
public partial class VocabularyCode {
    
    private string valueField;
    
    private string synonymField;
    
    private string displayNameField;
    
    private string codeSystemNameField;
    
    private string codeSystemField;
    
    private string categoryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "value")]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "synonym")]
    public string Synonym {
        get {
            return this.synonymField;
        }
        set {
            this.synonymField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "displayName")]
    public string DisplayName {
        get {
            return this.displayNameField;
        }
        set {
            this.displayNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "codeSystemName")]
    public string CodeSystemName {
        get {
            return this.codeSystemNameField;
        }
        set {
            this.codeSystemNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "codeSystem")]
    public string CodeSystem {
        get {
            return this.codeSystemField;
        }
        set {
            this.codeSystemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(AttributeName = "category")]
    public string Category {
        get {
            return this.categoryField;
        }
        set {
            this.categoryField = value;
        }
    }
}
