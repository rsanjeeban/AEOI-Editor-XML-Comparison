
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class File
{

    private FileSubmissions submissionsField;

    private FileFIs fIsField;

    private FileAccounts accountsField;

    private FileControllingPersons controllingPersonsField;

    private FileControls controlsField;

    private string fileNameField;

    private string ruleField;

    private string taskField;

    private string templateField;

    private System.DateTime createdOnField;

    /// <remarks/>
    public FileSubmissions Submissions
    {
        get
        {
            return this.submissionsField;
        }
        set
        {
            this.submissionsField = value;
        }
    }

    /// <remarks/>
    public FileFIs FIs
    {
        get
        {
            return this.fIsField;
        }
        set
        {
            this.fIsField = value;
        }
    }

    /// <remarks/>
    public FileAccounts Accounts
    {
        get
        {
            return this.accountsField;
        }
        set
        {
            this.accountsField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersons ControllingPersons
    {
        get
        {
            return this.controllingPersonsField;
        }
        set
        {
            this.controllingPersonsField = value;
        }
    }

    /// <remarks/>
    public FileControls Controls
    {
        get
        {
            return this.controlsField;
        }
        set
        {
            this.controlsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fileName
    {
        get
        {
            return this.fileNameField;
        }
        set
        {
            this.fileNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string rule
    {
        get
        {
            return this.ruleField;
        }
        set
        {
            this.ruleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string task
    {
        get
        {
            return this.taskField;
        }
        set
        {
            this.taskField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string template
    {
        get
        {
            return this.templateField;
        }
        set
        {
            this.templateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime createdOn
    {
        get
        {
            return this.createdOnField;
        }
        set
        {
            this.createdOnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissions
{

    private FileSubmissionsItem[] metaDataField;

    private FileSubmissionsSubmission submissionField;

    private string worksheetField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public FileSubmissionsItem[] MetaData
    {
        get
        {
            return this.metaDataField;
        }
        set
        {
            this.metaDataField = value;
        }
    }

    /// <remarks/>
    public FileSubmissionsSubmission Submission
    {
        get
        {
            return this.submissionField;
        }
        set
        {
            this.submissionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string worksheet
    {
        get
        {
            return this.worksheetField;
        }
        set
        {
            this.worksheetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsItem
{

    private string nameField;

    private string cellField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cell
    {
        get
        {
            return this.cellField;
        }
        set
        {
            this.cellField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmission
{

    private FileSubmissionsSubmissionSubmissionFormat submissionFormatField;

    private FileSubmissionsSubmissionTransmittingCountry transmittingCountryField;

    private FileSubmissionsSubmissionReportType reportTypeField;

    private FileSubmissionsSubmissionReportStart reportStartField;

    private FileSubmissionsSubmissionReportEnd reportEndField;

    private FileSubmissionsSubmissionFileNumber fileNumberField;

    private FileSubmissionsSubmissionSubmissionLabels submissionLabelsField;

    private FileSubmissionsSubmissionOriginalSubmissionRef originalSubmissionRefField;

    private byte rowField;

    /// <remarks/>
    public FileSubmissionsSubmissionSubmissionFormat SubmissionFormat
    {
        get
        {
            return this.submissionFormatField;
        }
        set
        {
            this.submissionFormatField = value;
        }
    }

    /// <remarks/>
    public FileSubmissionsSubmissionTransmittingCountry TransmittingCountry
    {
        get
        {
            return this.transmittingCountryField;
        }
        set
        {
            this.transmittingCountryField = value;
        }
    }

    /// <remarks/>
    public FileSubmissionsSubmissionReportType ReportType
    {
        get
        {
            return this.reportTypeField;
        }
        set
        {
            this.reportTypeField = value;
        }
    }

    /// <remarks/>
    public FileSubmissionsSubmissionReportStart ReportStart
    {
        get
        {
            return this.reportStartField;
        }
        set
        {
            this.reportStartField = value;
        }
    }

    /// <remarks/>
    public FileSubmissionsSubmissionReportEnd ReportEnd
    {
        get
        {
            return this.reportEndField;
        }
        set
        {
            this.reportEndField = value;
        }
    }

    /// <remarks/>
    public FileSubmissionsSubmissionFileNumber FileNumber
    {
        get
        {
            return this.fileNumberField;
        }
        set
        {
            this.fileNumberField = value;
        }
    }

    /// <remarks/>
    public FileSubmissionsSubmissionSubmissionLabels SubmissionLabels
    {
        get
        {
            return this.submissionLabelsField;
        }
        set
        {
            this.submissionLabelsField = value;
        }
    }

    /// <remarks/>
    public FileSubmissionsSubmissionOriginalSubmissionRef OriginalSubmissionRef
    {
        get
        {
            return this.originalSubmissionRefField;
        }
        set
        {
            this.originalSubmissionRefField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte row
    {
        get
        {
            return this.rowField;
        }
        set
        {
            this.rowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmissionSubmissionFormat
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmissionTransmittingCountry
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmissionReportType
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmissionReportStart
{

    private string columnField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
    public System.DateTime Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmissionReportEnd
{

    private string columnField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
    public System.DateTime Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmissionFileNumber
{

    private string columnField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmissionSubmissionLabels
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileSubmissionsSubmissionOriginalSubmissionRef
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIs
{

    private FileFIsFI[] fiField;

    private string worksheetField;
    private string username;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FI")]
    public FileFIsFI[] FI
    {
        get
        {
            return this.fiField;
        }
        set
        {
            this.fiField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string worksheet
    {
        get
        {
            return this.worksheetField;
        }
        set
        {
            this.worksheetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFI
{

    private FileFIsFIFIID fIIDField;

    private FileFIsFIName nameField;

    private FileFIsFIType typeField;

    private FileFIsFIIdentificationNumber identificationNumberField;

    private FileFIsFIAccountID accountIDField;

    private FileFIsFIBuildingIdentifier buildingIdentifierField;

    private FileFIsFIStreet streetField;

    private FileFIsFIDistrictName districtNameField;

    private FileFIsFICity cityField;

    private FileFIsFIPostCode postCodeField;

    private FileFIsFICountryCode countryCodeField;

    private FileFIsFIFILabels fILabelsField;

    private FileFIsFIOriginalDocRefId originalDocRefIdField;

    private object originalMessageRefField;

    private FileFIsFIDormantAccountElection dormantAccountElectionField;

    private FileFIsFIInsuranceElection insuranceElectionField;

    private byte rowField;

    /// <remarks/>
    public FileFIsFIFIID FIID
    {
        get
        {
            return this.fIIDField;
        }
        set
        {
            this.fIIDField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIName Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIType Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIIdentificationNumber IdentificationNumber
    {
        get
        {
            return this.identificationNumberField;
        }
        set
        {
            this.identificationNumberField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIAccountID AccountID
    {
        get
        {
            return this.accountIDField;
        }
        set
        {
            this.accountIDField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIBuildingIdentifier BuildingIdentifier
    {
        get
        {
            return this.buildingIdentifierField;
        }
        set
        {
            this.buildingIdentifierField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIStreet Street
    {
        get
        {
            return this.streetField;
        }
        set
        {
            this.streetField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIDistrictName DistrictName
    {
        get
        {
            return this.districtNameField;
        }
        set
        {
            this.districtNameField = value;
        }
    }

    /// <remarks/>
    public FileFIsFICity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIPostCode PostCode
    {
        get
        {
            return this.postCodeField;
        }
        set
        {
            this.postCodeField = value;
        }
    }

    /// <remarks/>
    public FileFIsFICountryCode CountryCode
    {
        get
        {
            return this.countryCodeField;
        }
        set
        {
            this.countryCodeField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIFILabels FILabels
    {
        get
        {
            return this.fILabelsField;
        }
        set
        {
            this.fILabelsField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIOriginalDocRefId OriginalDocRefId
    {
        get
        {
            return this.originalDocRefIdField;
        }
        set
        {
            this.originalDocRefIdField = value;
        }
    }

    /// <remarks/>
    public object OriginalMessageRef
    {
        get
        {
            return this.originalMessageRefField;
        }
        set
        {
            this.originalMessageRefField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIDormantAccountElection DormantAccountElection
    {
        get
        {
            return this.dormantAccountElectionField;
        }
        set
        {
            this.dormantAccountElectionField = value;
        }
    }

    /// <remarks/>
    public FileFIsFIInsuranceElection InsuranceElection
    {
        get
        {
            return this.insuranceElectionField;
        }
        set
        {
            this.insuranceElectionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte row
    {
        get
        {
            return this.rowField;
        }
        set
        {
            this.rowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIFIID
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIType
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIIdentificationNumber
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIAccountID
{

    private string columnField;

    private uint valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public uint Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIBuildingIdentifier
{

    private string columnField;

    private ushort valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public ushort Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIStreet
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIDistrictName
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFICity
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIPostCode
{

    private string columnField;

    private ushort valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public ushort Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFICountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIFILabels
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIOriginalDocRefId
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIDormantAccountElection
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileFIsFIInsuranceElection
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccounts
{

    private FileAccountsAccount[] accountField;

    private string worksheetField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Account")]
    public FileAccountsAccount[] Account
    {
        get
        {
            return this.accountField;
        }
        set
        {
            this.accountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string worksheet
    {
        get
        {
            return this.worksheetField;
        }
        set
        {
            this.worksheetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccount
{

    private FileAccountsAccountFIID fIIDField;

    private FileAccountsAccountAccountType accountTypeField;

    private FileAccountsAccountAccountNumber accountNumberField;

    private FileAccountsAccountAccountNumberType accountNumberTypeField;

    private FileAccountsAccountAccountStatus accountStatusField;

    private FileAccountsAccountCCY cCYField;

    private FileAccountsAccountFXRate fXRateField;

    private FileAccountsAccountAccountBalance accountBalanceField;

    private FileAccountsAccountInterest interestField;

    private FileAccountsAccountDividend dividendField;

    private FileAccountsAccountOtherIncome otherIncomeField;

    private FileAccountsAccountProceeds proceedsField;

    private FileAccountsAccountPersonType personTypeField;

    private object personSubTypeField;

    private FileAccountsAccountPersonRef personRefField;

    private FileAccountsAccountName nameField;

    private FileAccountsAccountPassiveNFE passiveNFEField;

    private FileAccountsAccountResCountryCode resCountryCodeField;

    private FileAccountsAccountResCountryCode2 resCountryCode2Field;

    private FileAccountsAccountResCountryCode3 resCountryCode3Field;

    private FileAccountsAccountResCountryCode4 resCountryCode4Field;

    private FileAccountsAccountTitle titleField;

    private FileAccountsAccountFirstName firstNameField;

    private FileAccountsAccountMiddleName middleNameField;

    private FileAccountsAccountLastName lastNameField;

    private FileAccountsAccountBirthDate birthDateField;

    private FileAccountsAccountBirthCity birthCityField;

    private FileAccountsAccountBirthCountryCode birthCountryCodeField;

    private FileAccountsAccountFormerCountryName formerCountryNameField;

    private FileAccountsAccountIdentificationNumber identificationNumberField;

    private FileAccountsAccountINType iNTypeField;

    private FileAccountsAccountINCountryCode iNCountryCodeField;

    private FileAccountsAccountIdentificationNumber2 identificationNumber2Field;

    private FileAccountsAccountINType2 iNType2Field;

    private FileAccountsAccountINCountryCode2 iNCountryCode2Field;

    private FileAccountsAccountIdentificationNumber3 identificationNumber3Field;

    private FileAccountsAccountINType3 iNType3Field;

    private FileAccountsAccountINCountryCode3 iNCountryCode3Field;

    private FileAccountsAccountIdentificationNumber4 identificationNumber4Field;

    private FileAccountsAccountINType4 iNType4Field;

    private FileAccountsAccountINCountryCode4 iNCountryCode4Field;

    private FileAccountsAccountSuiteIdentifier suiteIdentifierField;

    private FileAccountsAccountBuildingIdentifier buildingIdentifierField;

    private FileAccountsAccountStreet streetField;

    private FileAccountsAccountDistrictName districtNameField;

    private FileAccountsAccountCity cityField;

    private FileAccountsAccountPostCode postCodeField;

    private FileAccountsAccountCountryCode countryCodeField;

    private FileAccountsAccountIsUndocumented isUndocumentedField;

    private FileAccountsAccountOriginalDocRefId originalDocRefIdField;

    private byte rowField;

    /// <remarks/>
    public FileAccountsAccountFIID FIID
    {
        get
        {
            return this.fIIDField;
        }
        set
        {
            this.fIIDField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountAccountType AccountType
    {
        get
        {
            return this.accountTypeField;
        }
        set
        {
            this.accountTypeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountAccountNumber AccountNumber
    {
        get
        {
            return this.accountNumberField;
        }
        set
        {
            this.accountNumberField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountAccountNumberType AccountNumberType
    {
        get
        {
            return this.accountNumberTypeField;
        }
        set
        {
            this.accountNumberTypeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountAccountStatus AccountStatus
    {
        get
        {
            return this.accountStatusField;
        }
        set
        {
            this.accountStatusField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountCCY CCY
    {
        get
        {
            return this.cCYField;
        }
        set
        {
            this.cCYField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountFXRate FXRate
    {
        get
        {
            return this.fXRateField;
        }
        set
        {
            this.fXRateField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountAccountBalance AccountBalance
    {
        get
        {
            return this.accountBalanceField;
        }
        set
        {
            this.accountBalanceField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountInterest Interest
    {
        get
        {
            return this.interestField;
        }
        set
        {
            this.interestField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountDividend Dividend
    {
        get
        {
            return this.dividendField;
        }
        set
        {
            this.dividendField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountOtherIncome OtherIncome
    {
        get
        {
            return this.otherIncomeField;
        }
        set
        {
            this.otherIncomeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountProceeds Proceeds
    {
        get
        {
            return this.proceedsField;
        }
        set
        {
            this.proceedsField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountPersonType PersonType
    {
        get
        {
            return this.personTypeField;
        }
        set
        {
            this.personTypeField = value;
        }
    }

    /// <remarks/>
    public object PersonSubType
    {
        get
        {
            return this.personSubTypeField;
        }
        set
        {
            this.personSubTypeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountPersonRef PersonRef
    {
        get
        {
            return this.personRefField;
        }
        set
        {
            this.personRefField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountName Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountPassiveNFE PassiveNFE
    {
        get
        {
            return this.passiveNFEField;
        }
        set
        {
            this.passiveNFEField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountResCountryCode ResCountryCode
    {
        get
        {
            return this.resCountryCodeField;
        }
        set
        {
            this.resCountryCodeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountResCountryCode2 ResCountryCode2
    {
        get
        {
            return this.resCountryCode2Field;
        }
        set
        {
            this.resCountryCode2Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountResCountryCode3 ResCountryCode3
    {
        get
        {
            return this.resCountryCode3Field;
        }
        set
        {
            this.resCountryCode3Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountResCountryCode4 ResCountryCode4
    {
        get
        {
            return this.resCountryCode4Field;
        }
        set
        {
            this.resCountryCode4Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountTitle Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountFirstName FirstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountMiddleName MiddleName
    {
        get
        {
            return this.middleNameField;
        }
        set
        {
            this.middleNameField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountLastName LastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountBirthDate BirthDate
    {
        get
        {
            return this.birthDateField;
        }
        set
        {
            this.birthDateField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountBirthCity BirthCity
    {
        get
        {
            return this.birthCityField;
        }
        set
        {
            this.birthCityField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountBirthCountryCode BirthCountryCode
    {
        get
        {
            return this.birthCountryCodeField;
        }
        set
        {
            this.birthCountryCodeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountFormerCountryName FormerCountryName
    {
        get
        {
            return this.formerCountryNameField;
        }
        set
        {
            this.formerCountryNameField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountIdentificationNumber IdentificationNumber
    {
        get
        {
            return this.identificationNumberField;
        }
        set
        {
            this.identificationNumberField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountINType INType
    {
        get
        {
            return this.iNTypeField;
        }
        set
        {
            this.iNTypeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountINCountryCode INCountryCode
    {
        get
        {
            return this.iNCountryCodeField;
        }
        set
        {
            this.iNCountryCodeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountIdentificationNumber2 IdentificationNumber2
    {
        get
        {
            return this.identificationNumber2Field;
        }
        set
        {
            this.identificationNumber2Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountINType2 INType2
    {
        get
        {
            return this.iNType2Field;
        }
        set
        {
            this.iNType2Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountINCountryCode2 INCountryCode2
    {
        get
        {
            return this.iNCountryCode2Field;
        }
        set
        {
            this.iNCountryCode2Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountIdentificationNumber3 IdentificationNumber3
    {
        get
        {
            return this.identificationNumber3Field;
        }
        set
        {
            this.identificationNumber3Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountINType3 INType3
    {
        get
        {
            return this.iNType3Field;
        }
        set
        {
            this.iNType3Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountINCountryCode3 INCountryCode3
    {
        get
        {
            return this.iNCountryCode3Field;
        }
        set
        {
            this.iNCountryCode3Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountIdentificationNumber4 IdentificationNumber4
    {
        get
        {
            return this.identificationNumber4Field;
        }
        set
        {
            this.identificationNumber4Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountINType4 INType4
    {
        get
        {
            return this.iNType4Field;
        }
        set
        {
            this.iNType4Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountINCountryCode4 INCountryCode4
    {
        get
        {
            return this.iNCountryCode4Field;
        }
        set
        {
            this.iNCountryCode4Field = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountSuiteIdentifier SuiteIdentifier
    {
        get
        {
            return this.suiteIdentifierField;
        }
        set
        {
            this.suiteIdentifierField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountBuildingIdentifier BuildingIdentifier
    {
        get
        {
            return this.buildingIdentifierField;
        }
        set
        {
            this.buildingIdentifierField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountStreet Street
    {
        get
        {
            return this.streetField;
        }
        set
        {
            this.streetField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountDistrictName DistrictName
    {
        get
        {
            return this.districtNameField;
        }
        set
        {
            this.districtNameField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountPostCode PostCode
    {
        get
        {
            return this.postCodeField;
        }
        set
        {
            this.postCodeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountCountryCode CountryCode
    {
        get
        {
            return this.countryCodeField;
        }
        set
        {
            this.countryCodeField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountIsUndocumented IsUndocumented
    {
        get
        {
            return this.isUndocumentedField;
        }
        set
        {
            this.isUndocumentedField = value;
        }
    }

    /// <remarks/>
    public FileAccountsAccountOriginalDocRefId OriginalDocRefId
    {
        get
        {
            return this.originalDocRefIdField;
        }
        set
        {
            this.originalDocRefIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte row
    {
        get
        {
            return this.rowField;
        }
        set
        {
            this.rowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountFIID
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountAccountType
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountAccountNumber
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountAccountNumberType
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountAccountStatus
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountCCY
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountFXRate
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountAccountBalance
{

    private string columnField;

    private int valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public int Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountInterest
{

    private string columnField;

    private ushort valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public ushort Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountDividend
{

    private string columnField;

    private ushort valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public ushort Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountOtherIncome
{

    private string columnField;

    private ushort valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public ushort Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountProceeds
{

    private string columnField;

    private ushort valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public ushort Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountPersonType
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountPersonRef
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountPassiveNFE
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountResCountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountResCountryCode2
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountResCountryCode3
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountResCountryCode4
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountTitle
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountFirstName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountMiddleName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountLastName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountBirthDate
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountBirthCity
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountBirthCountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountFormerCountryName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountIdentificationNumber
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountINType
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountINCountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountIdentificationNumber2
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountINType2
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountINCountryCode2
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountIdentificationNumber3
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountINType3
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountINCountryCode3
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountIdentificationNumber4
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountINType4
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountINCountryCode4
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountSuiteIdentifier
{

    private string columnField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountBuildingIdentifier
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountStreet
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountDistrictName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountCity
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountPostCode
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountCountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountIsUndocumented
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileAccountsAccountOriginalDocRefId
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersons
{

    private FileControllingPersonsControllingPerson[] controllingPersonField;

    private string worksheetField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ControllingPerson")]
    public FileControllingPersonsControllingPerson[] ControllingPerson
    {
        get
        {
            return this.controllingPersonField;
        }
        set
        {
            this.controllingPersonField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string worksheet
    {
        get
        {
            return this.worksheetField;
        }
        set
        {
            this.worksheetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPerson
{

    private FileControllingPersonsControllingPersonFIID fIIDField;

    private FileControllingPersonsControllingPersonAccountNumber accountNumberField;

    private string personTypeField;

    private FileControllingPersonsControllingPersonRelationshipType relationshipTypeField;

    private FileControllingPersonsControllingPersonResCountryCode resCountryCodeField;

    private FileControllingPersonsControllingPersonResCountryCode2 resCountryCode2Field;

    private FileControllingPersonsControllingPersonResCountryCode3 resCountryCode3Field;

    private FileControllingPersonsControllingPersonResCountryCode4 resCountryCode4Field;

    private FileControllingPersonsControllingPersonPersonRef personRefField;

    private FileControllingPersonsControllingPersonTitle titleField;

    private FileControllingPersonsControllingPersonFirstName firstNameField;

    private FileControllingPersonsControllingPersonMiddleName middleNameField;

    private FileControllingPersonsControllingPersonLastName lastNameField;

    private FileControllingPersonsControllingPersonBirthDate birthDateField;

    private FileControllingPersonsControllingPersonBirthCity birthCityField;

    private FileControllingPersonsControllingPersonBirthCountryCode birthCountryCodeField;

    private FileControllingPersonsControllingPersonFormerCountryName formerCountryNameField;

    private FileControllingPersonsControllingPersonIdentificationNumber identificationNumberField;

    private FileControllingPersonsControllingPersonINType iNTypeField;

    private FileControllingPersonsControllingPersonINCountryCode iNCountryCodeField;

    private FileControllingPersonsControllingPersonIdentificationNumber2 identificationNumber2Field;

    private FileControllingPersonsControllingPersonINType2 iNType2Field;

    private FileControllingPersonsControllingPersonINCountryCode2 iNCountryCode2Field;

    private FileControllingPersonsControllingPersonIdentificationNumber3 identificationNumber3Field;

    private FileControllingPersonsControllingPersonINType3 iNType3Field;

    private FileControllingPersonsControllingPersonINCountryCode3 iNCountryCode3Field;

    private FileControllingPersonsControllingPersonIdentificationNumber4 identificationNumber4Field;

    private FileControllingPersonsControllingPersonINType4 iNType4Field;

    private FileControllingPersonsControllingPersonINCountryCode4 iNCountryCode4Field;

    private FileControllingPersonsControllingPersonSuiteIdentifier suiteIdentifierField;

    private FileControllingPersonsControllingPersonBuildingIdentifier buildingIdentifierField;

    private FileControllingPersonsControllingPersonStreet streetField;

    private FileControllingPersonsControllingPersonDistrictName districtNameField;

    private FileControllingPersonsControllingPersonCity cityField;

    private FileControllingPersonsControllingPersonPostCode postCodeField;

    private FileControllingPersonsControllingPersonCountryCode countryCodeField;

    private byte rowField;

    /// <remarks/>
    public FileControllingPersonsControllingPersonFIID FIID
    {
        get
        {
            return this.fIIDField;
        }
        set
        {
            this.fIIDField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonAccountNumber AccountNumber
    {
        get
        {
            return this.accountNumberField;
        }
        set
        {
            this.accountNumberField = value;
        }
    }

    /// <remarks/>
    public string PersonType
    {
        get
        {
            return this.personTypeField;
        }
        set
        {
            this.personTypeField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonRelationshipType RelationshipType
    {
        get
        {
            return this.relationshipTypeField;
        }
        set
        {
            this.relationshipTypeField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonResCountryCode ResCountryCode
    {
        get
        {
            return this.resCountryCodeField;
        }
        set
        {
            this.resCountryCodeField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonResCountryCode2 ResCountryCode2
    {
        get
        {
            return this.resCountryCode2Field;
        }
        set
        {
            this.resCountryCode2Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonResCountryCode3 ResCountryCode3
    {
        get
        {
            return this.resCountryCode3Field;
        }
        set
        {
            this.resCountryCode3Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonResCountryCode4 ResCountryCode4
    {
        get
        {
            return this.resCountryCode4Field;
        }
        set
        {
            this.resCountryCode4Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonPersonRef PersonRef
    {
        get
        {
            return this.personRefField;
        }
        set
        {
            this.personRefField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonTitle Title
    {
        get
        {
            return this.titleField;
        }
        set
        {
            this.titleField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonFirstName FirstName
    {
        get
        {
            return this.firstNameField;
        }
        set
        {
            this.firstNameField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonMiddleName MiddleName
    {
        get
        {
            return this.middleNameField;
        }
        set
        {
            this.middleNameField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonLastName LastName
    {
        get
        {
            return this.lastNameField;
        }
        set
        {
            this.lastNameField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonBirthDate BirthDate
    {
        get
        {
            return this.birthDateField;
        }
        set
        {
            this.birthDateField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonBirthCity BirthCity
    {
        get
        {
            return this.birthCityField;
        }
        set
        {
            this.birthCityField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonBirthCountryCode BirthCountryCode
    {
        get
        {
            return this.birthCountryCodeField;
        }
        set
        {
            this.birthCountryCodeField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonFormerCountryName FormerCountryName
    {
        get
        {
            return this.formerCountryNameField;
        }
        set
        {
            this.formerCountryNameField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonIdentificationNumber IdentificationNumber
    {
        get
        {
            return this.identificationNumberField;
        }
        set
        {
            this.identificationNumberField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonINType INType
    {
        get
        {
            return this.iNTypeField;
        }
        set
        {
            this.iNTypeField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonINCountryCode INCountryCode
    {
        get
        {
            return this.iNCountryCodeField;
        }
        set
        {
            this.iNCountryCodeField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonIdentificationNumber2 IdentificationNumber2
    {
        get
        {
            return this.identificationNumber2Field;
        }
        set
        {
            this.identificationNumber2Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonINType2 INType2
    {
        get
        {
            return this.iNType2Field;
        }
        set
        {
            this.iNType2Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonINCountryCode2 INCountryCode2
    {
        get
        {
            return this.iNCountryCode2Field;
        }
        set
        {
            this.iNCountryCode2Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonIdentificationNumber3 IdentificationNumber3
    {
        get
        {
            return this.identificationNumber3Field;
        }
        set
        {
            this.identificationNumber3Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonINType3 INType3
    {
        get
        {
            return this.iNType3Field;
        }
        set
        {
            this.iNType3Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonINCountryCode3 INCountryCode3
    {
        get
        {
            return this.iNCountryCode3Field;
        }
        set
        {
            this.iNCountryCode3Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonIdentificationNumber4 IdentificationNumber4
    {
        get
        {
            return this.identificationNumber4Field;
        }
        set
        {
            this.identificationNumber4Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonINType4 INType4
    {
        get
        {
            return this.iNType4Field;
        }
        set
        {
            this.iNType4Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonINCountryCode4 INCountryCode4
    {
        get
        {
            return this.iNCountryCode4Field;
        }
        set
        {
            this.iNCountryCode4Field = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonSuiteIdentifier SuiteIdentifier
    {
        get
        {
            return this.suiteIdentifierField;
        }
        set
        {
            this.suiteIdentifierField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonBuildingIdentifier BuildingIdentifier
    {
        get
        {
            return this.buildingIdentifierField;
        }
        set
        {
            this.buildingIdentifierField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonStreet Street
    {
        get
        {
            return this.streetField;
        }
        set
        {
            this.streetField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonDistrictName DistrictName
    {
        get
        {
            return this.districtNameField;
        }
        set
        {
            this.districtNameField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonCity City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonPostCode PostCode
    {
        get
        {
            return this.postCodeField;
        }
        set
        {
            this.postCodeField = value;
        }
    }

    /// <remarks/>
    public FileControllingPersonsControllingPersonCountryCode CountryCode
    {
        get
        {
            return this.countryCodeField;
        }
        set
        {
            this.countryCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte row
    {
        get
        {
            return this.rowField;
        }
        set
        {
            this.rowField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonFIID
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonAccountNumber
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonRelationshipType
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonResCountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonResCountryCode2
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonResCountryCode3
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonResCountryCode4
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonPersonRef
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonTitle
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonFirstName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonMiddleName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonLastName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonBirthDate
{

    private string columnField;

    private System.DateTime valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute(DataType = "date")]
    public System.DateTime Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonBirthCity
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonBirthCountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonFormerCountryName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonIdentificationNumber
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonINType
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonINCountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonIdentificationNumber2
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonINType2
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonINCountryCode2
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonIdentificationNumber3
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonINType3
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonINCountryCode3
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonIdentificationNumber4
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonINType4
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonINCountryCode4
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonSuiteIdentifier
{

    private string columnField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonBuildingIdentifier
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonStreet
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonDistrictName
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonCity
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonPostCode
{

    private string columnField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControllingPersonsControllingPersonCountryCode
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControls
{

    private FileControlsControl controlField;

    private string worksheetField;

    /// <remarks/>
    public FileControlsControl Control
    {
        get
        {
            return this.controlField;
        }
        set
        {
            this.controlField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string worksheet
    {
        get
        {
            return this.worksheetField;
        }
        set
        {
            this.worksheetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControlsControl
{

    private FileControlsControlDataRow dataRowField;

    private FileControlsControlHeaderRow headerRowField;

    private FileControlsControlStrict strictField;

    private FileControlsControlSchemas schemasField;

    private FileControlsControlSheetsToInclude sheetsToIncludeField;

    private FileControlsControlTemplateVersion templateVersionField;

    private string colField;

    /// <remarks/>
    public FileControlsControlDataRow DataRow
    {
        get
        {
            return this.dataRowField;
        }
        set
        {
            this.dataRowField = value;
        }
    }

    /// <remarks/>
    public FileControlsControlHeaderRow HeaderRow
    {
        get
        {
            return this.headerRowField;
        }
        set
        {
            this.headerRowField = value;
        }
    }

    /// <remarks/>
    public FileControlsControlStrict Strict
    {
        get
        {
            return this.strictField;
        }
        set
        {
            this.strictField = value;
        }
    }

    /// <remarks/>
    public FileControlsControlSchemas Schemas
    {
        get
        {
            return this.schemasField;
        }
        set
        {
            this.schemasField = value;
        }
    }

    /// <remarks/>
    public FileControlsControlSheetsToInclude SheetsToInclude
    {
        get
        {
            return this.sheetsToIncludeField;
        }
        set
        {
            this.sheetsToIncludeField = value;
        }
    }

    /// <remarks/>
    public FileControlsControlTemplateVersion TemplateVersion
    {
        get
        {
            return this.templateVersionField;
        }
        set
        {
            this.templateVersionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string col
    {
        get
        {
            return this.colField;
        }
        set
        {
            this.colField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControlsControlDataRow
{

    private string columnField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControlsControlHeaderRow
{

    private string columnField;

    private byte valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public byte Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControlsControlStrict
{

    private string columnField;

    private bool valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public bool Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControlsControlSchemas
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControlsControlSheetsToInclude
{

    private string columnField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class FileControlsControlTemplateVersion
{

    private string columnField;

    private decimal valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string column
    {
        get
        {
            return this.columnField;
        }
        set
        {
            this.columnField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

