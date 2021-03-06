// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: TwistWithCovariance.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TwistWithCovariance.proto</summary>
public static partial class TwistWithCovarianceReflection {

  #region Descriptor
  /// <summary>File descriptor for TwistWithCovariance.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TwistWithCovarianceReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlUd2lzdFdpdGhDb3ZhcmlhbmNlLnByb3RvGgtUd2lzdC5wcm90byIsChNU",
          "d2lzdFdpdGhDb3ZhcmlhbmNlEhUKBXR3aXN0GAEgASgLMgYuVHdpc3RiBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::TwistReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TwistWithCovariance), global::TwistWithCovariance.Parser, new[]{ "Twist" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class TwistWithCovariance : pb::IMessage<TwistWithCovariance> {
  private static readonly pb::MessageParser<TwistWithCovariance> _parser = new pb::MessageParser<TwistWithCovariance>(() => new TwistWithCovariance());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TwistWithCovariance> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TwistWithCovarianceReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TwistWithCovariance() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TwistWithCovariance(TwistWithCovariance other) : this() {
    Twist = other.twist_ != null ? other.Twist.Clone() : null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TwistWithCovariance Clone() {
    return new TwistWithCovariance(this);
  }

  /// <summary>Field number for the "twist" field.</summary>
  public const int TwistFieldNumber = 1;
  private global::Twist twist_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Twist Twist {
    get { return twist_; }
    set {
      twist_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TwistWithCovariance);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TwistWithCovariance other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Twist, other.Twist)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (twist_ != null) hash ^= Twist.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (twist_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Twist);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (twist_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Twist);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TwistWithCovariance other) {
    if (other == null) {
      return;
    }
    if (other.twist_ != null) {
      if (twist_ == null) {
        twist_ = new global::Twist();
      }
      Twist.MergeFrom(other.Twist);
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
          if (twist_ == null) {
            twist_ = new global::Twist();
          }
          input.ReadMessage(twist_);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
