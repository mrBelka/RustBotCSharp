// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: SEVData.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SEVData.proto</summary>
public static partial class SEVDataReflection {

  #region Descriptor
  /// <summary>File descriptor for SEVData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SEVDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1TRVZEYXRhLnByb3RvGgxIZWFkZXIucHJvdG8aC0ltYWdlLnByb3RvGhFQ",
          "b2ludENsb3VkMi5wcm90bxoPTmF2U2F0Rml4LnByb3RvGg5PZG9tZXRyeS5w",
          "cm90byK8AQoHU0VWRGF0YRIXCgZoZWFkZXIYASABKAsyBy5IZWFkZXISGgoK",
          "bGVmdF9pbWFnZRgCIAEoCzIGLkltYWdlEhsKC3JpZ2h0X2ltYWdlGAMgASgL",
          "MgYuSW1hZ2USIQoLcG9pbnRfY2xvdWQYBCABKAsyDC5Qb2ludENsb3VkMhIf",
          "CgtuYXZfc2F0X2ZpeBgFIAEoCzIKLk5hdlNhdEZpeBIbCghvZG9tZXRyeRgG",
          "IAEoCzIJLk9kb21ldHJ5YgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HeaderReflection.Descriptor, global::ImageReflection.Descriptor, global::PointCloud2Reflection.Descriptor, global::NavSatFixReflection.Descriptor, global::OdometryReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SEVData), global::SEVData.Parser, new[]{ "Header", "LeftImage", "RightImage", "PointCloud", "NavSatFix", "Odometry" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SEVData : pb::IMessage<SEVData> {
  private static readonly pb::MessageParser<SEVData> _parser = new pb::MessageParser<SEVData>(() => new SEVData());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SEVData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SEVDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SEVData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SEVData(SEVData other) : this() {
    Header = other.header_ != null ? other.Header.Clone() : null;
    LeftImage = other.leftImage_ != null ? other.LeftImage.Clone() : null;
    RightImage = other.rightImage_ != null ? other.RightImage.Clone() : null;
    PointCloud = other.pointCloud_ != null ? other.PointCloud.Clone() : null;
    NavSatFix = other.navSatFix_ != null ? other.NavSatFix.Clone() : null;
    Odometry = other.odometry_ != null ? other.Odometry.Clone() : null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SEVData Clone() {
    return new SEVData(this);
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

  /// <summary>Field number for the "left_image" field.</summary>
  public const int LeftImageFieldNumber = 2;
  private global::Image leftImage_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Image LeftImage {
    get { return leftImage_; }
    set {
      leftImage_ = value;
    }
  }

  /// <summary>Field number for the "right_image" field.</summary>
  public const int RightImageFieldNumber = 3;
  private global::Image rightImage_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Image RightImage {
    get { return rightImage_; }
    set {
      rightImage_ = value;
    }
  }

  /// <summary>Field number for the "point_cloud" field.</summary>
  public const int PointCloudFieldNumber = 4;
  private global::PointCloud2 pointCloud_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::PointCloud2 PointCloud {
    get { return pointCloud_; }
    set {
      pointCloud_ = value;
    }
  }

  /// <summary>Field number for the "nav_sat_fix" field.</summary>
  public const int NavSatFixFieldNumber = 5;
  private global::NavSatFix navSatFix_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::NavSatFix NavSatFix {
    get { return navSatFix_; }
    set {
      navSatFix_ = value;
    }
  }

  /// <summary>Field number for the "odometry" field.</summary>
  public const int OdometryFieldNumber = 6;
  private global::Odometry odometry_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Odometry Odometry {
    get { return odometry_; }
    set {
      odometry_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SEVData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SEVData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Header, other.Header)) return false;
    if (!object.Equals(LeftImage, other.LeftImage)) return false;
    if (!object.Equals(RightImage, other.RightImage)) return false;
    if (!object.Equals(PointCloud, other.PointCloud)) return false;
    if (!object.Equals(NavSatFix, other.NavSatFix)) return false;
    if (!object.Equals(Odometry, other.Odometry)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (header_ != null) hash ^= Header.GetHashCode();
    if (leftImage_ != null) hash ^= LeftImage.GetHashCode();
    if (rightImage_ != null) hash ^= RightImage.GetHashCode();
    if (pointCloud_ != null) hash ^= PointCloud.GetHashCode();
    if (navSatFix_ != null) hash ^= NavSatFix.GetHashCode();
    if (odometry_ != null) hash ^= Odometry.GetHashCode();
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
    if (leftImage_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(LeftImage);
    }
    if (rightImage_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(RightImage);
    }
    if (pointCloud_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(PointCloud);
    }
    if (navSatFix_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(NavSatFix);
    }
    if (odometry_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(Odometry);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (header_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
    }
    if (leftImage_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(LeftImage);
    }
    if (rightImage_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(RightImage);
    }
    if (pointCloud_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(PointCloud);
    }
    if (navSatFix_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(NavSatFix);
    }
    if (odometry_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Odometry);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SEVData other) {
    if (other == null) {
      return;
    }
    if (other.header_ != null) {
      if (header_ == null) {
        header_ = new global::Header();
      }
      Header.MergeFrom(other.Header);
    }
    if (other.leftImage_ != null) {
      if (leftImage_ == null) {
        leftImage_ = new global::Image();
      }
      LeftImage.MergeFrom(other.LeftImage);
    }
    if (other.rightImage_ != null) {
      if (rightImage_ == null) {
        rightImage_ = new global::Image();
      }
      RightImage.MergeFrom(other.RightImage);
    }
    if (other.pointCloud_ != null) {
      if (pointCloud_ == null) {
        pointCloud_ = new global::PointCloud2();
      }
      PointCloud.MergeFrom(other.PointCloud);
    }
    if (other.navSatFix_ != null) {
      if (navSatFix_ == null) {
        navSatFix_ = new global::NavSatFix();
      }
      NavSatFix.MergeFrom(other.NavSatFix);
    }
    if (other.odometry_ != null) {
      if (odometry_ == null) {
        odometry_ = new global::Odometry();
      }
      Odometry.MergeFrom(other.Odometry);
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
        case 18: {
          if (leftImage_ == null) {
            leftImage_ = new global::Image();
          }
          input.ReadMessage(leftImage_);
          break;
        }
        case 26: {
          if (rightImage_ == null) {
            rightImage_ = new global::Image();
          }
          input.ReadMessage(rightImage_);
          break;
        }
        case 34: {
          if (pointCloud_ == null) {
            pointCloud_ = new global::PointCloud2();
          }
          input.ReadMessage(pointCloud_);
          break;
        }
        case 42: {
          if (navSatFix_ == null) {
            navSatFix_ = new global::NavSatFix();
          }
          input.ReadMessage(navSatFix_);
          break;
        }
        case 50: {
          if (odometry_ == null) {
            odometry_ = new global::Odometry();
          }
          input.ReadMessage(odometry_);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
