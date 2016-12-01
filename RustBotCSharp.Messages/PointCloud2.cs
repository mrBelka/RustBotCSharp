// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: PointCloud2.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PointCloud2.proto</summary>
public static partial class PointCloud2Reflection {

  #region Descriptor
  /// <summary>File descriptor for PointCloud2.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PointCloud2Reflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFQb2ludENsb3VkMi5wcm90bxoMSGVhZGVyLnByb3RvGhBQb2ludEZpZWxk",
          "LnByb3RvIqwBCgtQb2ludENsb3VkMhIXCgZoZWFkZXIYASABKAsyBy5IZWFk",
          "ZXISDgoGaGVpZ2h0GAIgASgFEg0KBXdpZHRoGAMgASgFEhsKBmZpZWxkcxgE",
          "IAMoCzILLlBvaW50RmllbGQSFAoMaXNfYmlnZW5kaWFuGAUgASgIEhIKCnBv",
          "aW50X3N0ZXAYBiABKAUSEAoIcm93X3N0ZXAYByABKAUSDAoEZGF0YRgIIAEo",
          "DGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HeaderReflection.Descriptor, global::PointFieldReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PointCloud2), global::PointCloud2.Parser, new[]{ "Header", "Height", "Width", "Fields", "IsBigendian", "PointStep", "RowStep", "Data" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class PointCloud2 : pb::IMessage<PointCloud2> {
  private static readonly pb::MessageParser<PointCloud2> _parser = new pb::MessageParser<PointCloud2>(() => new PointCloud2());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<PointCloud2> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PointCloud2Reflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PointCloud2() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PointCloud2(PointCloud2 other) : this() {
    Header = other.header_ != null ? other.Header.Clone() : null;
    height_ = other.height_;
    width_ = other.width_;
    fields_ = other.fields_.Clone();
    isBigendian_ = other.isBigendian_;
    pointStep_ = other.pointStep_;
    rowStep_ = other.rowStep_;
    data_ = other.data_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PointCloud2 Clone() {
    return new PointCloud2(this);
  }

  /// <summary>Field number for the "header" field.</summary>
  public const int HeaderFieldNumber = 1;
  private global::Header header_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Header Header {
    get { return header_; }
    set {
      header_ = value;
    }
  }

  /// <summary>Field number for the "height" field.</summary>
  public const int HeightFieldNumber = 2;
  private int height_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Height {
    get { return height_; }
    set {
      height_ = value;
    }
  }

  /// <summary>Field number for the "width" field.</summary>
  public const int WidthFieldNumber = 3;
  private int width_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Width {
    get { return width_; }
    set {
      width_ = value;
    }
  }

  /// <summary>Field number for the "fields" field.</summary>
  public const int FieldsFieldNumber = 4;
  private static readonly pb::FieldCodec<global::PointField> _repeated_fields_codec
      = pb::FieldCodec.ForMessage(34, global::PointField.Parser);
  private readonly pbc::RepeatedField<global::PointField> fields_ = new pbc::RepeatedField<global::PointField>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::PointField> Fields {
    get { return fields_; }
  }

  /// <summary>Field number for the "is_bigendian" field.</summary>
  public const int IsBigendianFieldNumber = 5;
  private bool isBigendian_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool IsBigendian {
    get { return isBigendian_; }
    set {
      isBigendian_ = value;
    }
  }

  /// <summary>Field number for the "point_step" field.</summary>
  public const int PointStepFieldNumber = 6;
  private int pointStep_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int PointStep {
    get { return pointStep_; }
    set {
      pointStep_ = value;
    }
  }

  /// <summary>Field number for the "row_step" field.</summary>
  public const int RowStepFieldNumber = 7;
  private int rowStep_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int RowStep {
    get { return rowStep_; }
    set {
      rowStep_ = value;
    }
  }

  /// <summary>Field number for the "data" field.</summary>
  public const int DataFieldNumber = 8;
  private pb::ByteString data_ = pb::ByteString.Empty;
  /// <summary>
  /// repeated PointXYZRGB points = 2;
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Data {
    get { return data_; }
    set {
      data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as PointCloud2);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(PointCloud2 other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Header, other.Header)) return false;
    if (Height != other.Height) return false;
    if (Width != other.Width) return false;
    if(!fields_.Equals(other.fields_)) return false;
    if (IsBigendian != other.IsBigendian) return false;
    if (PointStep != other.PointStep) return false;
    if (RowStep != other.RowStep) return false;
    if (Data != other.Data) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (header_ != null) hash ^= Header.GetHashCode();
    if (Height != 0) hash ^= Height.GetHashCode();
    if (Width != 0) hash ^= Width.GetHashCode();
    hash ^= fields_.GetHashCode();
    if (IsBigendian != false) hash ^= IsBigendian.GetHashCode();
    if (PointStep != 0) hash ^= PointStep.GetHashCode();
    if (RowStep != 0) hash ^= RowStep.GetHashCode();
    if (Data.Length != 0) hash ^= Data.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (header_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Header);
    }
    if (Height != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Height);
    }
    if (Width != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Width);
    }
    fields_.WriteTo(output, _repeated_fields_codec);
    if (IsBigendian != false) {
      output.WriteRawTag(40);
      output.WriteBool(IsBigendian);
    }
    if (PointStep != 0) {
      output.WriteRawTag(48);
      output.WriteInt32(PointStep);
    }
    if (RowStep != 0) {
      output.WriteRawTag(56);
      output.WriteInt32(RowStep);
    }
    if (Data.Length != 0) {
      output.WriteRawTag(66);
      output.WriteBytes(Data);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (header_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
    }
    if (Height != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
    }
    if (Width != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
    }
    size += fields_.CalculateSize(_repeated_fields_codec);
    if (IsBigendian != false) {
      size += 1 + 1;
    }
    if (PointStep != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PointStep);
    }
    if (RowStep != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(RowStep);
    }
    if (Data.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(PointCloud2 other) {
    if (other == null) {
      return;
    }
    if (other.header_ != null) {
      if (header_ == null) {
        header_ = new global::Header();
      }
      Header.MergeFrom(other.Header);
    }
    if (other.Height != 0) {
      Height = other.Height;
    }
    if (other.Width != 0) {
      Width = other.Width;
    }
    fields_.Add(other.fields_);
    if (other.IsBigendian != false) {
      IsBigendian = other.IsBigendian;
    }
    if (other.PointStep != 0) {
      PointStep = other.PointStep;
    }
    if (other.RowStep != 0) {
      RowStep = other.RowStep;
    }
    if (other.Data.Length != 0) {
      Data = other.Data;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          if (header_ == null) {
            header_ = new global::Header();
          }
          input.ReadMessage(header_);
          break;
        }
        case 16: {
          Height = input.ReadInt32();
          break;
        }
        case 24: {
          Width = input.ReadInt32();
          break;
        }
        case 34: {
          fields_.AddEntriesFrom(input, _repeated_fields_codec);
          break;
        }
        case 40: {
          IsBigendian = input.ReadBool();
          break;
        }
        case 48: {
          PointStep = input.ReadInt32();
          break;
        }
        case 56: {
          RowStep = input.ReadInt32();
          break;
        }
        case 66: {
          Data = input.ReadBytes();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
