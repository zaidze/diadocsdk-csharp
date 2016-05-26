//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Documents/InvoiceDocument.proto
namespace Diadoc.Api.Proto.Documents.InvoiceDocument
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InvoiceMetadata")]
  public partial class InvoiceMetadata : global::ProtoBuf.IExtensible
  {
    public InvoiceMetadata() {}
    

    private Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus _InvoiceStatus = Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus.UnknownInvoiceStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"InvoiceStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus.UnknownInvoiceStatus)]
    public Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus InvoiceStatus
    {
      get { return _InvoiceStatus; }
      set { _InvoiceStatus = value; }
    }
    private string _Total;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }
    private string _Vat;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }
    private int _Currency;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }
    private long _ConfirmationDateTimeTicks;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ConfirmationDateTimeTicks", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public long ConfirmationDateTimeTicks
    {
      get { return _ConfirmationDateTimeTicks; }
      set { _ConfirmationDateTimeTicks = value; }
    }
    private int _InvoiceAmendmentFlags;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"InvoiceAmendmentFlags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int InvoiceAmendmentFlags
    {
      get { return _InvoiceAmendmentFlags; }
      set { _InvoiceAmendmentFlags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InvoiceRevisionMetadata")]
  public partial class InvoiceRevisionMetadata : global::ProtoBuf.IExtensible
  {
    public InvoiceRevisionMetadata() {}
    

    private Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus _InvoiceRevisionStatus = Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus.UnknownInvoiceStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"InvoiceRevisionStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus.UnknownInvoiceStatus)]
    public Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus InvoiceRevisionStatus
    {
      get { return _InvoiceRevisionStatus; }
      set { _InvoiceRevisionStatus = value; }
    }
    private string _OriginalInvoiceNumber;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"OriginalInvoiceNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalInvoiceNumber
    {
      get { return _OriginalInvoiceNumber; }
      set { _OriginalInvoiceNumber = value; }
    }
    private string _OriginalInvoiceDate;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"OriginalInvoiceDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalInvoiceDate
    {
      get { return _OriginalInvoiceDate; }
      set { _OriginalInvoiceDate = value; }
    }
    private string _Total;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }
    private string _Vat;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }
    private int _Currency;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }
    private long _ConfirmationDateTimeTicks;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"ConfirmationDateTimeTicks", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public long ConfirmationDateTimeTicks
    {
      get { return _ConfirmationDateTimeTicks; }
      set { _ConfirmationDateTimeTicks = value; }
    }
    private int _InvoiceAmendmentFlags;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"InvoiceAmendmentFlags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int InvoiceAmendmentFlags
    {
      get { return _InvoiceAmendmentFlags; }
      set { _InvoiceAmendmentFlags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InvoiceCorrectionMetadata")]
  public partial class InvoiceCorrectionMetadata : global::ProtoBuf.IExtensible
  {
    public InvoiceCorrectionMetadata() {}
    

    private Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus _InvoiceCorrectionStatus = Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus.UnknownInvoiceStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"InvoiceCorrectionStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus.UnknownInvoiceStatus)]
    public Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus InvoiceCorrectionStatus
    {
      get { return _InvoiceCorrectionStatus; }
      set { _InvoiceCorrectionStatus = value; }
    }
    private string _OriginalInvoiceNumber;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"OriginalInvoiceNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalInvoiceNumber
    {
      get { return _OriginalInvoiceNumber; }
      set { _OriginalInvoiceNumber = value; }
    }
    private string _OriginalInvoiceDate;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"OriginalInvoiceDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalInvoiceDate
    {
      get { return _OriginalInvoiceDate; }
      set { _OriginalInvoiceDate = value; }
    }

    private string _OriginalInvoiceRevisionNumber = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"OriginalInvoiceRevisionNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OriginalInvoiceRevisionNumber
    {
      get { return _OriginalInvoiceRevisionNumber; }
      set { _OriginalInvoiceRevisionNumber = value; }
    }

    private string _OriginalInvoiceRevisionDate = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"OriginalInvoiceRevisionDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OriginalInvoiceRevisionDate
    {
      get { return _OriginalInvoiceRevisionDate; }
      set { _OriginalInvoiceRevisionDate = value; }
    }
    private string _TotalInc;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"TotalInc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TotalInc
    {
      get { return _TotalInc; }
      set { _TotalInc = value; }
    }
    private string _TotalDec;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"TotalDec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TotalDec
    {
      get { return _TotalDec; }
      set { _TotalDec = value; }
    }
    private string _VatInc;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"VatInc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string VatInc
    {
      get { return _VatInc; }
      set { _VatInc = value; }
    }
    private string _VatDec;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"VatDec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string VatDec
    {
      get { return _VatDec; }
      set { _VatDec = value; }
    }
    private int _Currency;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }
    private long _ConfirmationDateTimeTicks;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"ConfirmationDateTimeTicks", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public long ConfirmationDateTimeTicks
    {
      get { return _ConfirmationDateTimeTicks; }
      set { _ConfirmationDateTimeTicks = value; }
    }
    private int _InvoiceAmendmentFlags;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"InvoiceAmendmentFlags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int InvoiceAmendmentFlags
    {
      get { return _InvoiceAmendmentFlags; }
      set { _InvoiceAmendmentFlags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InvoiceCorrectionRevisionMetadata")]
  public partial class InvoiceCorrectionRevisionMetadata : global::ProtoBuf.IExtensible
  {
    public InvoiceCorrectionRevisionMetadata() {}
    

    private Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus _InvoiceCorrectionRevisionStatus = Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus.UnknownInvoiceStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"InvoiceCorrectionRevisionStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus.UnknownInvoiceStatus)]
    public Diadoc.Api.Proto.Documents.InvoiceDocument.InvoiceStatus InvoiceCorrectionRevisionStatus
    {
      get { return _InvoiceCorrectionRevisionStatus; }
      set { _InvoiceCorrectionRevisionStatus = value; }
    }
    private string _OriginalInvoiceNumber;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"OriginalInvoiceNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalInvoiceNumber
    {
      get { return _OriginalInvoiceNumber; }
      set { _OriginalInvoiceNumber = value; }
    }
    private string _OriginalInvoiceDate;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"OriginalInvoiceDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalInvoiceDate
    {
      get { return _OriginalInvoiceDate; }
      set { _OriginalInvoiceDate = value; }
    }

    private string _OriginalInvoiceRevisionNumber = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"OriginalInvoiceRevisionNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OriginalInvoiceRevisionNumber
    {
      get { return _OriginalInvoiceRevisionNumber; }
      set { _OriginalInvoiceRevisionNumber = value; }
    }

    private string _OriginalInvoiceRevisionDate = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"OriginalInvoiceRevisionDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OriginalInvoiceRevisionDate
    {
      get { return _OriginalInvoiceRevisionDate; }
      set { _OriginalInvoiceRevisionDate = value; }
    }
    private string _OriginalInvoiceCorrectionNumber;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"OriginalInvoiceCorrectionNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalInvoiceCorrectionNumber
    {
      get { return _OriginalInvoiceCorrectionNumber; }
      set { _OriginalInvoiceCorrectionNumber = value; }
    }
    private string _OriginalInvoiceCorrectionDate;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"OriginalInvoiceCorrectionDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OriginalInvoiceCorrectionDate
    {
      get { return _OriginalInvoiceCorrectionDate; }
      set { _OriginalInvoiceCorrectionDate = value; }
    }
    private string _TotalInc;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"TotalInc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TotalInc
    {
      get { return _TotalInc; }
      set { _TotalInc = value; }
    }
    private string _TotalDec;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"TotalDec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string TotalDec
    {
      get { return _TotalDec; }
      set { _TotalDec = value; }
    }
    private string _VatInc;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"VatInc", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string VatInc
    {
      get { return _VatInc; }
      set { _VatInc = value; }
    }
    private string _VatDec;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"VatDec", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string VatDec
    {
      get { return _VatDec; }
      set { _VatDec = value; }
    }
    private int _Currency;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }
    private long _ConfirmationDateTimeTicks;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"ConfirmationDateTimeTicks", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public long ConfirmationDateTimeTicks
    {
      get { return _ConfirmationDateTimeTicks; }
      set { _ConfirmationDateTimeTicks = value; }
    }
    private int _InvoiceAmendmentFlags;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"InvoiceAmendmentFlags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int InvoiceAmendmentFlags
    {
      get { return _InvoiceAmendmentFlags; }
      set { _InvoiceAmendmentFlags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"InvoiceStatus")]
    public enum InvoiceStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UnknownInvoiceStatus", Value=0)]
      UnknownInvoiceStatus = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForInvoiceReceipt", Value=1)]
      OutboundWaitingForInvoiceReceipt = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundNotFinished", Value=2)]
      OutboundNotFinished = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundFinished", Value=3)]
      OutboundFinished = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForSenderSignature", Value=6)]
      OutboundWaitingForSenderSignature = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundInvalidSenderSignature", Value=7)]
      OutboundInvalidSenderSignature = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundNotFinished", Value=4)]
      InboundNotFinished = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundFinished", Value=5)]
      InboundFinished = 5
    }
  
}