// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: qlua/rpc/getCandlesByIndex.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Qlua.Rpc.GetCandlesByIndex {

  /// <summary>Holder for reflection information generated from qlua/rpc/getCandlesByIndex.proto</summary>
  public static partial class GetCandlesByIndexReflection {

    #region Descriptor
    /// <summary>File descriptor for qlua/rpc/getCandlesByIndex.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetCandlesByIndexReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBxbHVhL3JwYy9nZXRDYW5kbGVzQnlJbmRleC5wcm90bxIacWx1YS5ycGMu",
            "Z2V0Q2FuZGxlc0J5SW5kZXgaHnFsdWEvcnBjL3FsdWFfc3RydWN0dXJlcy5w",
            "cm90byJGCgRBcmdzEgsKA3RhZxgBIAEoCRIMCgRsaW5lGAIgASgFEhQKDGZp",
            "cnN0X2NhbmRsZRgDIAEoBRINCgVjb3VudBgEIAEoBSJECgZSZXN1bHQSJAoB",
            "dBgBIAMoCzIZLnFsdWEuc3RydWN0cy5DYW5kbGVFbnRyeRIJCgFuGAIgASgF",
            "EgkKAWwYAyABKAlCDAoIcWx1YS5ycGNIAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Qlua.Structs.QluaStructuresReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Qlua.Rpc.GetCandlesByIndex.Args), global::Qlua.Rpc.GetCandlesByIndex.Args.Parser, new[]{ "Tag", "Line", "FirstCandle", "Count" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Qlua.Rpc.GetCandlesByIndex.Result), global::Qlua.Rpc.GetCandlesByIndex.Result.Parser, new[]{ "T", "N", "L" }, null, null, null, null)
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
      get { return global::Qlua.Rpc.GetCandlesByIndex.GetCandlesByIndexReflection.Descriptor.MessageTypes[0]; }
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
      tag_ = other.tag_;
      line_ = other.line_;
      firstCandle_ = other.firstCandle_;
      count_ = other.count_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Args Clone() {
      return new Args(this);
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 1;
    private string tag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "line" field.</summary>
    public const int LineFieldNumber = 2;
    private int line_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Line {
      get { return line_; }
      set {
        line_ = value;
      }
    }

    /// <summary>Field number for the "first_candle" field.</summary>
    public const int FirstCandleFieldNumber = 3;
    private int firstCandle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FirstCandle {
      get { return firstCandle_; }
      set {
        firstCandle_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 4;
    private int count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
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
      if (Tag != other.Tag) return false;
      if (Line != other.Line) return false;
      if (FirstCandle != other.FirstCandle) return false;
      if (Count != other.Count) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
      if (Line != 0) hash ^= Line.GetHashCode();
      if (FirstCandle != 0) hash ^= FirstCandle.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
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
      if (Tag.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Tag);
      }
      if (Line != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Line);
      }
      if (FirstCandle != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(FirstCandle);
      }
      if (Count != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Count);
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
      if (Tag.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Tag);
      }
      if (Line != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Line);
      }
      if (FirstCandle != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(FirstCandle);
      }
      if (Count != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Count);
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
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (Line != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Line);
      }
      if (FirstCandle != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FirstCandle);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
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
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
      }
      if (other.Line != 0) {
        Line = other.Line;
      }
      if (other.FirstCandle != 0) {
        FirstCandle = other.FirstCandle;
      }
      if (other.Count != 0) {
        Count = other.Count;
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
            Tag = input.ReadString();
            break;
          }
          case 16: {
            Line = input.ReadInt32();
            break;
          }
          case 24: {
            FirstCandle = input.ReadInt32();
            break;
          }
          case 32: {
            Count = input.ReadInt32();
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
            Tag = input.ReadString();
            break;
          }
          case 16: {
            Line = input.ReadInt32();
            break;
          }
          case 24: {
            FirstCandle = input.ReadInt32();
            break;
          }
          case 32: {
            Count = input.ReadInt32();
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
      get { return global::Qlua.Rpc.GetCandlesByIndex.GetCandlesByIndexReflection.Descriptor.MessageTypes[1]; }
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
      t_ = other.t_.Clone();
      n_ = other.n_;
      l_ = other.l_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Result Clone() {
      return new Result(this);
    }

    /// <summary>Field number for the "t" field.</summary>
    public const int TFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Qlua.Structs.CandleEntry> _repeated_t_codec
        = pb::FieldCodec.ForMessage(10, global::Qlua.Structs.CandleEntry.Parser);
    private readonly pbc::RepeatedField<global::Qlua.Structs.CandleEntry> t_ = new pbc::RepeatedField<global::Qlua.Structs.CandleEntry>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Qlua.Structs.CandleEntry> T {
      get { return t_; }
    }

    /// <summary>Field number for the "n" field.</summary>
    public const int NFieldNumber = 2;
    private int n_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int N {
      get { return n_; }
      set {
        n_ = value;
      }
    }

    /// <summary>Field number for the "l" field.</summary>
    public const int LFieldNumber = 3;
    private string l_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string L {
      get { return l_; }
      set {
        l_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
      if(!t_.Equals(other.t_)) return false;
      if (N != other.N) return false;
      if (L != other.L) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= t_.GetHashCode();
      if (N != 0) hash ^= N.GetHashCode();
      if (L.Length != 0) hash ^= L.GetHashCode();
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
      t_.WriteTo(output, _repeated_t_codec);
      if (N != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(N);
      }
      if (L.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(L);
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
      t_.WriteTo(ref output, _repeated_t_codec);
      if (N != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(N);
      }
      if (L.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(L);
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
      size += t_.CalculateSize(_repeated_t_codec);
      if (N != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(N);
      }
      if (L.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(L);
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
      t_.Add(other.t_);
      if (other.N != 0) {
        N = other.N;
      }
      if (other.L.Length != 0) {
        L = other.L;
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
            t_.AddEntriesFrom(input, _repeated_t_codec);
            break;
          }
          case 16: {
            N = input.ReadInt32();
            break;
          }
          case 26: {
            L = input.ReadString();
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
            t_.AddEntriesFrom(ref input, _repeated_t_codec);
            break;
          }
          case 16: {
            N = input.ReadInt32();
            break;
          }
          case 26: {
            L = input.ReadString();
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
