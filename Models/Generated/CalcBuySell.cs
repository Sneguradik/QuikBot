// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: qlua/rpc/CalcBuySell.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Qlua.Rpc.CalcBuySell {

  /// <summary>Holder for reflection information generated from qlua/rpc/CalcBuySell.proto</summary>
  public static partial class CalcBuySellReflection {

    #region Descriptor
    /// <summary>File descriptor for qlua/rpc/CalcBuySell.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CalcBuySellReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpxbHVhL3JwYy9DYWxjQnV5U2VsbC5wcm90bxIUcWx1YS5ycGMuQ2FsY0J1",
            "eVNlbGwihAEKBEFyZ3MSEgoKY2xhc3NfY29kZRgBIAEoCRIQCghzZWNfY29k",
            "ZRgCIAEoCRITCgtjbGllbnRfY29kZRgDIAEoCRIPCgdhY2NvdW50GAQgASgJ",
            "Eg0KBXByaWNlGAUgASgJEg4KBmlzX2J1eRgGIAEoCBIRCglpc19tYXJrZXQY",
            "ByABKAgiKAoGUmVzdWx0EgsKA3F0eRgBIAEoBRIRCgljb21pc3Npb24YAiAB",
            "KAlCDAoIcWx1YS5ycGNIAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Qlua.Rpc.CalcBuySell.Args), global::Qlua.Rpc.CalcBuySell.Args.Parser, new[]{ "ClassCode", "SecCode", "ClientCode", "Account", "Price", "IsBuy", "IsMarket" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Qlua.Rpc.CalcBuySell.Result), global::Qlua.Rpc.CalcBuySell.Result.Parser, new[]{ "Qty", "Comission" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Args : pb::IMessage<Args>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Args> _parser = new pb::MessageParser<Args>(() => new Args());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Args> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Qlua.Rpc.CalcBuySell.CalcBuySellReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Args() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Args(Args other) : this() {
      classCode_ = other.classCode_;
      secCode_ = other.secCode_;
      clientCode_ = other.clientCode_;
      account_ = other.account_;
      price_ = other.price_;
      isBuy_ = other.isBuy_;
      isMarket_ = other.isMarket_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Args Clone() {
      return new Args(this);
    }

    /// <summary>Field number for the "class_code" field.</summary>
    public const int ClassCodeFieldNumber = 1;
    private string classCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClassCode {
      get { return classCode_; }
      set {
        classCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sec_code" field.</summary>
    public const int SecCodeFieldNumber = 2;
    private string secCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SecCode {
      get { return secCode_; }
      set {
        secCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_code" field.</summary>
    public const int ClientCodeFieldNumber = 3;
    private string clientCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientCode {
      get { return clientCode_; }
      set {
        clientCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "account" field.</summary>
    public const int AccountFieldNumber = 4;
    private string account_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Account {
      get { return account_; }
      set {
        account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 5;
    private string price_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Price {
      get { return price_; }
      set {
        price_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_buy" field.</summary>
    public const int IsBuyFieldNumber = 6;
    private bool isBuy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsBuy {
      get { return isBuy_; }
      set {
        isBuy_ = value;
      }
    }

    /// <summary>Field number for the "is_market" field.</summary>
    public const int IsMarketFieldNumber = 7;
    private bool isMarket_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMarket {
      get { return isMarket_; }
      set {
        isMarket_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Args);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Args other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClassCode != other.ClassCode) return false;
      if (SecCode != other.SecCode) return false;
      if (ClientCode != other.ClientCode) return false;
      if (Account != other.Account) return false;
      if (Price != other.Price) return false;
      if (IsBuy != other.IsBuy) return false;
      if (IsMarket != other.IsMarket) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClassCode.Length != 0) hash ^= ClassCode.GetHashCode();
      if (SecCode.Length != 0) hash ^= SecCode.GetHashCode();
      if (ClientCode.Length != 0) hash ^= ClientCode.GetHashCode();
      if (Account.Length != 0) hash ^= Account.GetHashCode();
      if (Price.Length != 0) hash ^= Price.GetHashCode();
      if (IsBuy != false) hash ^= IsBuy.GetHashCode();
      if (IsMarket != false) hash ^= IsMarket.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ClassCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassCode);
      }
      if (SecCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SecCode);
      }
      if (ClientCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ClientCode);
      }
      if (Account.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Account);
      }
      if (Price.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Price);
      }
      if (IsBuy != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsBuy);
      }
      if (IsMarket != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsMarket);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ClassCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassCode);
      }
      if (SecCode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SecCode);
      }
      if (ClientCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ClientCode);
      }
      if (Account.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Account);
      }
      if (Price.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Price);
      }
      if (IsBuy != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsBuy);
      }
      if (IsMarket != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsMarket);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ClassCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClassCode);
      }
      if (SecCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SecCode);
      }
      if (ClientCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientCode);
      }
      if (Account.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
      }
      if (Price.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Price);
      }
      if (IsBuy != false) {
        size += 1 + 1;
      }
      if (IsMarket != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Args other) {
      if (other == null) {
        return;
      }
      if (other.ClassCode.Length != 0) {
        ClassCode = other.ClassCode;
      }
      if (other.SecCode.Length != 0) {
        SecCode = other.SecCode;
      }
      if (other.ClientCode.Length != 0) {
        ClientCode = other.ClientCode;
      }
      if (other.Account.Length != 0) {
        Account = other.Account;
      }
      if (other.Price.Length != 0) {
        Price = other.Price;
      }
      if (other.IsBuy != false) {
        IsBuy = other.IsBuy;
      }
      if (other.IsMarket != false) {
        IsMarket = other.IsMarket;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ClassCode = input.ReadString();
            break;
          }
          case 18: {
            SecCode = input.ReadString();
            break;
          }
          case 26: {
            ClientCode = input.ReadString();
            break;
          }
          case 34: {
            Account = input.ReadString();
            break;
          }
          case 42: {
            Price = input.ReadString();
            break;
          }
          case 48: {
            IsBuy = input.ReadBool();
            break;
          }
          case 56: {
            IsMarket = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ClassCode = input.ReadString();
            break;
          }
          case 18: {
            SecCode = input.ReadString();
            break;
          }
          case 26: {
            ClientCode = input.ReadString();
            break;
          }
          case 34: {
            Account = input.ReadString();
            break;
          }
          case 42: {
            Price = input.ReadString();
            break;
          }
          case 48: {
            IsBuy = input.ReadBool();
            break;
          }
          case 56: {
            IsMarket = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Result : pb::IMessage<Result>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Result> _parser = new pb::MessageParser<Result>(() => new Result());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Result> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Qlua.Rpc.CalcBuySell.CalcBuySellReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Result() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Result(Result other) : this() {
      qty_ = other.qty_;
      comission_ = other.comission_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Result Clone() {
      return new Result(this);
    }

    /// <summary>Field number for the "qty" field.</summary>
    public const int QtyFieldNumber = 1;
    private int qty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Qty {
      get { return qty_; }
      set {
        qty_ = value;
      }
    }

    /// <summary>Field number for the "comission" field.</summary>
    public const int ComissionFieldNumber = 2;
    private string comission_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Comission {
      get { return comission_; }
      set {
        comission_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Result);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Result other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Qty != other.Qty) return false;
      if (Comission != other.Comission) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Qty != 0) hash ^= Qty.GetHashCode();
      if (Comission.Length != 0) hash ^= Comission.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Qty != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Qty);
      }
      if (Comission.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Comission);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Qty != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Qty);
      }
      if (Comission.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Comission);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Qty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Qty);
      }
      if (Comission.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Comission);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Result other) {
      if (other == null) {
        return;
      }
      if (other.Qty != 0) {
        Qty = other.Qty;
      }
      if (other.Comission.Length != 0) {
        Comission = other.Comission;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Qty = input.ReadInt32();
            break;
          }
          case 18: {
            Comission = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Qty = input.ReadInt32();
            break;
          }
          case 18: {
            Comission = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
