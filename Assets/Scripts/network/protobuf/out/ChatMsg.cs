// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChatMsg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protobuf {

  /// <summary>Holder for reflection information generated from ChatMsg.proto</summary>
  public static partial class ChatMsgReflection {

    #region Descriptor
    /// <summary>File descriptor for ChatMsg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatMsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1DaGF0TXNnLnByb3RvEghwcm90b2J1ZiI0CgdNc2dJbmZvEgoKAnRvGAIg",
            "AigJEgsKA21zZxgDIAIoCRIQCghzZW5kVHlwZRgEIAIoByJOCgRDaGF0EhMK",
            "C2FjY2Vzc1Rva2VuGAEgASgJEhAKCGlkZW50aWZ5GAIgAigJEhEKCXRvdGFs",
            "U2l6ZRgDIAIoBxIMCgRkYXRhGAQgAigMQi0KHW9yZy5nb3JhLnNlcnZlci5t",
            "b2RlbC5uZXR3b3JrQgxDaGF0UHJvdG9CdWY="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protobuf.MsgInfo), global::Protobuf.MsgInfo.Parser, new[]{ "To", "Msg", "SendType" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protobuf.Chat), global::Protobuf.Chat.Parser, new[]{ "AccessToken", "Identify", "TotalSize", "Data" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MsgInfo : pb::IMessage<MsgInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MsgInfo> _parser = new pb::MessageParser<MsgInfo>(() => new MsgInfo());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MsgInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protobuf.ChatMsgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgInfo(MsgInfo other) : this() {
      _hasBits0 = other._hasBits0;
      to_ = other.to_;
      msg_ = other.msg_;
      sendType_ = other.sendType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgInfo Clone() {
      return new MsgInfo(this);
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 2;
    private readonly static string ToDefaultValue = "";

    private string to_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string To {
      get { return to_ ?? ToDefaultValue; }
      set {
        to_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "to" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTo {
      get { return to_ != null; }
    }
    /// <summary>Clears the value of the "to" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTo() {
      to_ = null;
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 3;
    private readonly static string MsgDefaultValue = "";

    private string msg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Msg {
      get { return msg_ ?? MsgDefaultValue; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "msg" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMsg {
      get { return msg_ != null; }
    }
    /// <summary>Clears the value of the "msg" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMsg() {
      msg_ = null;
    }

    /// <summary>Field number for the "sendType" field.</summary>
    public const int SendTypeFieldNumber = 4;
    private readonly static uint SendTypeDefaultValue = 0;

    private uint sendType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SendType {
      get { if ((_hasBits0 & 1) != 0) { return sendType_; } else { return SendTypeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        sendType_ = value;
      }
    }
    /// <summary>Gets whether the "sendType" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSendType {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "sendType" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSendType() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MsgInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MsgInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (To != other.To) return false;
      if (Msg != other.Msg) return false;
      if (SendType != other.SendType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasTo) hash ^= To.GetHashCode();
      if (HasMsg) hash ^= Msg.GetHashCode();
      if (HasSendType) hash ^= SendType.GetHashCode();
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
      if (HasTo) {
        output.WriteRawTag(18);
        output.WriteString(To);
      }
      if (HasMsg) {
        output.WriteRawTag(26);
        output.WriteString(Msg);
      }
      if (HasSendType) {
        output.WriteRawTag(37);
        output.WriteFixed32(SendType);
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
      if (HasTo) {
        output.WriteRawTag(18);
        output.WriteString(To);
      }
      if (HasMsg) {
        output.WriteRawTag(26);
        output.WriteString(Msg);
      }
      if (HasSendType) {
        output.WriteRawTag(37);
        output.WriteFixed32(SendType);
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
      if (HasTo) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(To);
      }
      if (HasMsg) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (HasSendType) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MsgInfo other) {
      if (other == null) {
        return;
      }
      if (other.HasTo) {
        To = other.To;
      }
      if (other.HasMsg) {
        Msg = other.Msg;
      }
      if (other.HasSendType) {
        SendType = other.SendType;
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            To = input.ReadString();
            break;
          }
          case 26: {
            Msg = input.ReadString();
            break;
          }
          case 37: {
            SendType = input.ReadFixed32();
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            To = input.ReadString();
            break;
          }
          case 26: {
            Msg = input.ReadString();
            break;
          }
          case 37: {
            SendType = input.ReadFixed32();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Chat : pb::IMessage<Chat>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Chat> _parser = new pb::MessageParser<Chat>(() => new Chat());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Chat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protobuf.ChatMsgReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Chat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Chat(Chat other) : this() {
      _hasBits0 = other._hasBits0;
      accessToken_ = other.accessToken_;
      identify_ = other.identify_;
      totalSize_ = other.totalSize_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Chat Clone() {
      return new Chat(this);
    }

    /// <summary>Field number for the "accessToken" field.</summary>
    public const int AccessTokenFieldNumber = 1;
    private readonly static string AccessTokenDefaultValue = "";

    private string accessToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AccessToken {
      get { return accessToken_ ?? AccessTokenDefaultValue; }
      set {
        accessToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "accessToken" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAccessToken {
      get { return accessToken_ != null; }
    }
    /// <summary>Clears the value of the "accessToken" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAccessToken() {
      accessToken_ = null;
    }

    /// <summary>Field number for the "identify" field.</summary>
    public const int IdentifyFieldNumber = 2;
    private readonly static string IdentifyDefaultValue = "";

    private string identify_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Identify {
      get { return identify_ ?? IdentifyDefaultValue; }
      set {
        identify_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "identify" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasIdentify {
      get { return identify_ != null; }
    }
    /// <summary>Clears the value of the "identify" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearIdentify() {
      identify_ = null;
    }

    /// <summary>Field number for the "totalSize" field.</summary>
    public const int TotalSizeFieldNumber = 3;
    private readonly static uint TotalSizeDefaultValue = 0;

    private uint totalSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalSize {
      get { if ((_hasBits0 & 1) != 0) { return totalSize_; } else { return TotalSizeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        totalSize_ = value;
      }
    }
    /// <summary>Gets whether the "totalSize" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTotalSize {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "totalSize" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTotalSize() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 4;
    private readonly static pb::ByteString DataDefaultValue = pb::ByteString.Empty;

    private pb::ByteString data_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString Data {
      get { return data_ ?? DataDefaultValue; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "data" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasData {
      get { return data_ != null; }
    }
    /// <summary>Clears the value of the "data" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearData() {
      data_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Chat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Chat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccessToken != other.AccessToken) return false;
      if (Identify != other.Identify) return false;
      if (TotalSize != other.TotalSize) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasAccessToken) hash ^= AccessToken.GetHashCode();
      if (HasIdentify) hash ^= Identify.GetHashCode();
      if (HasTotalSize) hash ^= TotalSize.GetHashCode();
      if (HasData) hash ^= Data.GetHashCode();
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
      if (HasAccessToken) {
        output.WriteRawTag(10);
        output.WriteString(AccessToken);
      }
      if (HasIdentify) {
        output.WriteRawTag(18);
        output.WriteString(Identify);
      }
      if (HasTotalSize) {
        output.WriteRawTag(29);
        output.WriteFixed32(TotalSize);
      }
      if (HasData) {
        output.WriteRawTag(34);
        output.WriteBytes(Data);
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
      if (HasAccessToken) {
        output.WriteRawTag(10);
        output.WriteString(AccessToken);
      }
      if (HasIdentify) {
        output.WriteRawTag(18);
        output.WriteString(Identify);
      }
      if (HasTotalSize) {
        output.WriteRawTag(29);
        output.WriteFixed32(TotalSize);
      }
      if (HasData) {
        output.WriteRawTag(34);
        output.WriteBytes(Data);
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
      if (HasAccessToken) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccessToken);
      }
      if (HasIdentify) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Identify);
      }
      if (HasTotalSize) {
        size += 1 + 4;
      }
      if (HasData) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Chat other) {
      if (other == null) {
        return;
      }
      if (other.HasAccessToken) {
        AccessToken = other.AccessToken;
      }
      if (other.HasIdentify) {
        Identify = other.Identify;
      }
      if (other.HasTotalSize) {
        TotalSize = other.TotalSize;
      }
      if (other.HasData) {
        Data = other.Data;
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AccessToken = input.ReadString();
            break;
          }
          case 18: {
            Identify = input.ReadString();
            break;
          }
          case 29: {
            TotalSize = input.ReadFixed32();
            break;
          }
          case 34: {
            Data = input.ReadBytes();
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            AccessToken = input.ReadString();
            break;
          }
          case 18: {
            Identify = input.ReadString();
            break;
          }
          case 29: {
            TotalSize = input.ReadFixed32();
            break;
          }
          case 34: {
            Data = input.ReadBytes();
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
