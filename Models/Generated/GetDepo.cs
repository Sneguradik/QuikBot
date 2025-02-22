// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: qlua/rpc/getDepo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Qlua.Rpc.GetDepo {

  /// <summary>Holder for reflection information generated from qlua/rpc/getDepo.proto</summary>
  public static partial class GetDepoReflection {

    #region Descriptor
    /// <summary>File descriptor for qlua/rpc/getDepo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetDepoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZxbHVhL3JwYy9nZXREZXBvLnByb3RvEhBxbHVhLnJwYy5nZXREZXBvIvEB",
            "CgREZXBvEiMKG2RlcG9fbGltaXRfbG9ja2VkX2J1eV92YWx1ZRgBIAEoCRIc",
            "ChRkZXBvX2N1cnJlbnRfYmFsYW5jZRgCIAEoCRIdChVkZXBvX2xpbWl0X2xv",
            "Y2tlZF9idXkYAyABKAkSGQoRZGVwb19saW1pdF9sb2NrZWQYBCABKAkSHAoU",
            "ZGVwb19saW1pdF9hdmFpbGFibGUYBSABKAkSGgoSZGVwb19jdXJyZW50X2xp",
            "bWl0GAYgASgJEhkKEWRlcG9fb3Blbl9iYWxhbmNlGAcgASgJEhcKD2RlcG9f",
            "b3Blbl9saW1pdBgIIAEoCSJPCgRBcmdzEhMKC2NsaWVudF9jb2RlGAEgASgJ",
            "Eg4KBmZpcm1pZBgCIAEoCRIQCghzZWNfY29kZRgDIAEoCRIQCgh0cmRhY2Np",
            "ZBgEIAEoCSIuCgZSZXN1bHQSJAoEZGVwbxgBIAEoCzIWLnFsdWEucnBjLmdl",
            "dERlcG8uRGVwb0IMCghxbHVhLnJwY0gBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Qlua.Rpc.GetDepo.Depo), global::Qlua.Rpc.GetDepo.Depo.Parser, new[]{ "DepoLimitLockedBuyValue", "DepoCurrentBalance", "DepoLimitLockedBuy", "DepoLimitLocked", "DepoLimitAvailable", "DepoCurrentLimit", "DepoOpenBalance", "DepoOpenLimit" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Qlua.Rpc.GetDepo.Args), global::Qlua.Rpc.GetDepo.Args.Parser, new[]{ "ClientCode", "Firmid", "SecCode", "Trdaccid" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Qlua.Rpc.GetDepo.Result), global::Qlua.Rpc.GetDepo.Result.Parser, new[]{ "Depo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Depo : pb::IMessage<Depo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Depo> _parser = new pb::MessageParser<Depo>(() => new Depo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Depo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Qlua.Rpc.GetDepo.GetDepoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Depo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Depo(Depo other) : this() {
      depoLimitLockedBuyValue_ = other.depoLimitLockedBuyValue_;
      depoCurrentBalance_ = other.depoCurrentBalance_;
      depoLimitLockedBuy_ = other.depoLimitLockedBuy_;
      depoLimitLocked_ = other.depoLimitLocked_;
      depoLimitAvailable_ = other.depoLimitAvailable_;
      depoCurrentLimit_ = other.depoCurrentLimit_;
      depoOpenBalance_ = other.depoOpenBalance_;
      depoOpenLimit_ = other.depoOpenLimit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Depo Clone() {
      return new Depo(this);
    }

    /// <summary>Field number for the "depo_limit_locked_buy_value" field.</summary>
    public const int DepoLimitLockedBuyValueFieldNumber = 1;
    private string depoLimitLockedBuyValue_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DepoLimitLockedBuyValue {
      get { return depoLimitLockedBuyValue_; }
      set {
        depoLimitLockedBuyValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "depo_current_balance" field.</summary>
    public const int DepoCurrentBalanceFieldNumber = 2;
    private string depoCurrentBalance_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DepoCurrentBalance {
      get { return depoCurrentBalance_; }
      set {
        depoCurrentBalance_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "depo_limit_locked_buy" field.</summary>
    public const int DepoLimitLockedBuyFieldNumber = 3;
    private string depoLimitLockedBuy_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DepoLimitLockedBuy {
      get { return depoLimitLockedBuy_; }
      set {
        depoLimitLockedBuy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "depo_limit_locked" field.</summary>
    public const int DepoLimitLockedFieldNumber = 4;
    private string depoLimitLocked_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DepoLimitLocked {
      get { return depoLimitLocked_; }
      set {
        depoLimitLocked_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "depo_limit_available" field.</summary>
    public const int DepoLimitAvailableFieldNumber = 5;
    private string depoLimitAvailable_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DepoLimitAvailable {
      get { return depoLimitAvailable_; }
      set {
        depoLimitAvailable_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "depo_current_limit" field.</summary>
    public const int DepoCurrentLimitFieldNumber = 6;
    private string depoCurrentLimit_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DepoCurrentLimit {
      get { return depoCurrentLimit_; }
      set {
        depoCurrentLimit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "depo_open_balance" field.</summary>
    public const int DepoOpenBalanceFieldNumber = 7;
    private string depoOpenBalance_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DepoOpenBalance {
      get { return depoOpenBalance_; }
      set {
        depoOpenBalance_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "depo_open_limit" field.</summary>
    public const int DepoOpenLimitFieldNumber = 8;
    private string depoOpenLimit_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DepoOpenLimit {
      get { return depoOpenLimit_; }
      set {
        depoOpenLimit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Depo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Depo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DepoLimitLockedBuyValue != other.DepoLimitLockedBuyValue) return false;
      if (DepoCurrentBalance != other.DepoCurrentBalance) return false;
      if (DepoLimitLockedBuy != other.DepoLimitLockedBuy) return false;
      if (DepoLimitLocked != other.DepoLimitLocked) return false;
      if (DepoLimitAvailable != other.DepoLimitAvailable) return false;
      if (DepoCurrentLimit != other.DepoCurrentLimit) return false;
      if (DepoOpenBalance != other.DepoOpenBalance) return false;
      if (DepoOpenLimit != other.DepoOpenLimit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DepoLimitLockedBuyValue.Length != 0) hash ^= DepoLimitLockedBuyValue.GetHashCode();
      if (DepoCurrentBalance.Length != 0) hash ^= DepoCurrentBalance.GetHashCode();
      if (DepoLimitLockedBuy.Length != 0) hash ^= DepoLimitLockedBuy.GetHashCode();
      if (DepoLimitLocked.Length != 0) hash ^= DepoLimitLocked.GetHashCode();
      if (DepoLimitAvailable.Length != 0) hash ^= DepoLimitAvailable.GetHashCode();
      if (DepoCurrentLimit.Length != 0) hash ^= DepoCurrentLimit.GetHashCode();
      if (DepoOpenBalance.Length != 0) hash ^= DepoOpenBalance.GetHashCode();
      if (DepoOpenLimit.Length != 0) hash ^= DepoOpenLimit.GetHashCode();
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
      if (DepoLimitLockedBuyValue.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DepoLimitLockedBuyValue);
      }
      if (DepoCurrentBalance.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DepoCurrentBalance);
      }
      if (DepoLimitLockedBuy.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DepoLimitLockedBuy);
      }
      if (DepoLimitLocked.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DepoLimitLocked);
      }
      if (DepoLimitAvailable.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DepoLimitAvailable);
      }
      if (DepoCurrentLimit.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(DepoCurrentLimit);
      }
      if (DepoOpenBalance.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DepoOpenBalance);
      }
      if (DepoOpenLimit.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(DepoOpenLimit);
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
      if (DepoLimitLockedBuyValue.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DepoLimitLockedBuyValue);
      }
      if (DepoCurrentBalance.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DepoCurrentBalance);
      }
      if (DepoLimitLockedBuy.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DepoLimitLockedBuy);
      }
      if (DepoLimitLocked.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DepoLimitLocked);
      }
      if (DepoLimitAvailable.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DepoLimitAvailable);
      }
      if (DepoCurrentLimit.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(DepoCurrentLimit);
      }
      if (DepoOpenBalance.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DepoOpenBalance);
      }
      if (DepoOpenLimit.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(DepoOpenLimit);
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
      if (DepoLimitLockedBuyValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DepoLimitLockedBuyValue);
      }
      if (DepoCurrentBalance.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DepoCurrentBalance);
      }
      if (DepoLimitLockedBuy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DepoLimitLockedBuy);
      }
      if (DepoLimitLocked.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DepoLimitLocked);
      }
      if (DepoLimitAvailable.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DepoLimitAvailable);
      }
      if (DepoCurrentLimit.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DepoCurrentLimit);
      }
      if (DepoOpenBalance.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DepoOpenBalance);
      }
      if (DepoOpenLimit.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DepoOpenLimit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Depo other) {
      if (other == null) {
        return;
      }
      if (other.DepoLimitLockedBuyValue.Length != 0) {
        DepoLimitLockedBuyValue = other.DepoLimitLockedBuyValue;
      }
      if (other.DepoCurrentBalance.Length != 0) {
        DepoCurrentBalance = other.DepoCurrentBalance;
      }
      if (other.DepoLimitLockedBuy.Length != 0) {
        DepoLimitLockedBuy = other.DepoLimitLockedBuy;
      }
      if (other.DepoLimitLocked.Length != 0) {
        DepoLimitLocked = other.DepoLimitLocked;
      }
      if (other.DepoLimitAvailable.Length != 0) {
        DepoLimitAvailable = other.DepoLimitAvailable;
      }
      if (other.DepoCurrentLimit.Length != 0) {
        DepoCurrentLimit = other.DepoCurrentLimit;
      }
      if (other.DepoOpenBalance.Length != 0) {
        DepoOpenBalance = other.DepoOpenBalance;
      }
      if (other.DepoOpenLimit.Length != 0) {
        DepoOpenLimit = other.DepoOpenLimit;
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
            DepoLimitLockedBuyValue = input.ReadString();
            break;
          }
          case 18: {
            DepoCurrentBalance = input.ReadString();
            break;
          }
          case 26: {
            DepoLimitLockedBuy = input.ReadString();
            break;
          }
          case 34: {
            DepoLimitLocked = input.ReadString();
            break;
          }
          case 42: {
            DepoLimitAvailable = input.ReadString();
            break;
          }
          case 50: {
            DepoCurrentLimit = input.ReadString();
            break;
          }
          case 58: {
            DepoOpenBalance = input.ReadString();
            break;
          }
          case 66: {
            DepoOpenLimit = input.ReadString();
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
            DepoLimitLockedBuyValue = input.ReadString();
            break;
          }
          case 18: {
            DepoCurrentBalance = input.ReadString();
            break;
          }
          case 26: {
            DepoLimitLockedBuy = input.ReadString();
            break;
          }
          case 34: {
            DepoLimitLocked = input.ReadString();
            break;
          }
          case 42: {
            DepoLimitAvailable = input.ReadString();
            break;
          }
          case 50: {
            DepoCurrentLimit = input.ReadString();
            break;
          }
          case 58: {
            DepoOpenBalance = input.ReadString();
            break;
          }
          case 66: {
            DepoOpenLimit = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

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
      get { return global::Qlua.Rpc.GetDepo.GetDepoReflection.Descriptor.MessageTypes[1]; }
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
      clientCode_ = other.clientCode_;
      firmid_ = other.firmid_;
      secCode_ = other.secCode_;
      trdaccid_ = other.trdaccid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Args Clone() {
      return new Args(this);
    }

    /// <summary>Field number for the "client_code" field.</summary>
    public const int ClientCodeFieldNumber = 1;
    private string clientCode_ = "";
    /// <summary>
    /// Код клиента
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientCode {
      get { return clientCode_; }
      set {
        clientCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "firmid" field.</summary>
    public const int FirmidFieldNumber = 2;
    private string firmid_ = "";
    /// <summary>
    /// Фирма
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Firmid {
      get { return firmid_; }
      set {
        firmid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sec_code" field.</summary>
    public const int SecCodeFieldNumber = 3;
    private string secCode_ = "";
    /// <summary>
    /// Код бумаги
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SecCode {
      get { return secCode_; }
      set {
        secCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "trdaccid" field.</summary>
    public const int TrdaccidFieldNumber = 4;
    private string trdaccid_ = "";
    /// <summary>
    /// Счет депо
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Trdaccid {
      get { return trdaccid_; }
      set {
        trdaccid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
      if (ClientCode != other.ClientCode) return false;
      if (Firmid != other.Firmid) return false;
      if (SecCode != other.SecCode) return false;
      if (Trdaccid != other.Trdaccid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientCode.Length != 0) hash ^= ClientCode.GetHashCode();
      if (Firmid.Length != 0) hash ^= Firmid.GetHashCode();
      if (SecCode.Length != 0) hash ^= SecCode.GetHashCode();
      if (Trdaccid.Length != 0) hash ^= Trdaccid.GetHashCode();
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
      if (ClientCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientCode);
      }
      if (Firmid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Firmid);
      }
      if (SecCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SecCode);
      }
      if (Trdaccid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Trdaccid);
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
      if (ClientCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientCode);
      }
      if (Firmid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Firmid);
      }
      if (SecCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SecCode);
      }
      if (Trdaccid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Trdaccid);
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
      if (ClientCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientCode);
      }
      if (Firmid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Firmid);
      }
      if (SecCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SecCode);
      }
      if (Trdaccid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Trdaccid);
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
      if (other.ClientCode.Length != 0) {
        ClientCode = other.ClientCode;
      }
      if (other.Firmid.Length != 0) {
        Firmid = other.Firmid;
      }
      if (other.SecCode.Length != 0) {
        SecCode = other.SecCode;
      }
      if (other.Trdaccid.Length != 0) {
        Trdaccid = other.Trdaccid;
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
            ClientCode = input.ReadString();
            break;
          }
          case 18: {
            Firmid = input.ReadString();
            break;
          }
          case 26: {
            SecCode = input.ReadString();
            break;
          }
          case 34: {
            Trdaccid = input.ReadString();
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
            ClientCode = input.ReadString();
            break;
          }
          case 18: {
            Firmid = input.ReadString();
            break;
          }
          case 26: {
            SecCode = input.ReadString();
            break;
          }
          case 34: {
            Trdaccid = input.ReadString();
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
      get { return global::Qlua.Rpc.GetDepo.GetDepoReflection.Descriptor.MessageTypes[2]; }
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
      depo_ = other.depo_ != null ? other.depo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Result Clone() {
      return new Result(this);
    }

    /// <summary>Field number for the "depo" field.</summary>
    public const int DepoFieldNumber = 1;
    private global::Qlua.Rpc.GetDepo.Depo depo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Qlua.Rpc.GetDepo.Depo Depo {
      get { return depo_; }
      set {
        depo_ = value;
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
      if (!object.Equals(Depo, other.Depo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (depo_ != null) hash ^= Depo.GetHashCode();
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
      if (depo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Depo);
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
      if (depo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Depo);
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
      if (depo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Depo);
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
      if (other.depo_ != null) {
        if (depo_ == null) {
          Depo = new global::Qlua.Rpc.GetDepo.Depo();
        }
        Depo.MergeFrom(other.Depo);
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
            if (depo_ == null) {
              Depo = new global::Qlua.Rpc.GetDepo.Depo();
            }
            input.ReadMessage(Depo);
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
            if (depo_ == null) {
              Depo = new global::Qlua.Rpc.GetDepo.Depo();
            }
            input.ReadMessage(Depo);
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
