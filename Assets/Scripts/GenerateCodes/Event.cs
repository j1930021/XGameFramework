//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protofiles/Event.proto
namespace dbc
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventTable")]
  public partial class EventTable : global::ProtoBuf.IExtensible
  {
    public EventTable() {}
    
    private string _tname = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tname
    {
      get { return _tname; }
      set { _tname = value; }
    }
    private readonly global::System.Collections.Generic.List<dbc.Event> _tlist = new global::System.Collections.Generic.List<dbc.Event>();
    [global::ProtoBuf.ProtoMember(2, Name=@"tlist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<dbc.Event> tlist
    {
      get { return _tlist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Event")]
  public partial class Event : global::ProtoBuf.IExtensible
  {
    public Event() {}
    
    private int _ID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private int _SectionId = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SectionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int SectionId
    {
      get { return _SectionId; }
      set { _SectionId = value; }
    }
    private int _Type = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private int _TrigRate = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TrigRate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int TrigRate
    {
      get { return _TrigRate; }
      set { _TrigRate = value; }
    }
    private int _PreCond = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PreCond", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int PreCond
    {
      get { return _PreCond; }
      set { _PreCond = value; }
    }
    private int _CondValue = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CondValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int CondValue
    {
      get { return _CondValue; }
      set { _CondValue = value; }
    }
    private int _ExeRate = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ExeRate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ExeRate
    {
      get { return _ExeRate; }
      set { _ExeRate = value; }
    }
    private string _SucText = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"SucText", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string SucText
    {
      get { return _SucText; }
      set { _SucText = value; }
    }
    private string _FailText = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"FailText", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string FailText
    {
      get { return _FailText; }
      set { _FailText = value; }
    }
    private int _SucResultType = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"SucResultType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int SucResultType
    {
      get { return _SucResultType; }
      set { _SucResultType = value; }
    }
    private int _SucResultValue = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"SucResultValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int SucResultValue
    {
      get { return _SucResultValue; }
      set { _SucResultValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}