// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Vector3.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Vector3.proto</summary>
public static partial class Vector3Reflection {

  #region Descriptor
  /// <summary>File descriptor for Vector3.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static Vector3Reflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg1WZWN0b3IzLnByb3RvIioKB1ZlY3RvcjMSCQoBeBgBIAEoARIJCgF5GAIg",
          "ASgBEgkKAXoYAyABKAFiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Vector3), global::Vector3.Parser, new[]{ "X", "Y", "Z" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Vector3 : pb::IMessage<Vector3> {
  private static readonly pb::MessageParser<Vector3> _parser = new pb::MessageParser<Vector3>(() => new Vector3());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Vector3> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::Vector3Reflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Vector3() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Vector3(Vector3 other) : this() {
    x_ = other.x_;
    y_ = other.y_;
    z_ = other.z_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Vector3 Clone() {
    return new Vector3(this);
  }

  /// <summary>Field number for the "x" field.</summary>
  public const int XFieldNumber = 1;
  private double x_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double X {
    get { return x_; }
    set {
      x_ = value;
    }
  }

  /// <summary>Field number for the "y" field.</summary>
  public const int YFieldNumber = 2;
  private double y_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double Y {
    get { return y_; }
    set {
      y_ = value;
    }
  }

  /// <summary>Field number for the "z" field.</summary>
  public const int ZFieldNumber = 3;
  private double z_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public double Z {
    get { return z_; }
    set {
      z_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Vector3);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Vector3 other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (X != other.X) return false;
    if (Y != other.Y) return false;
    if (Z != other.Z) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (X != 0D) hash ^= X.GetHashCode();
    if (Y != 0D) hash ^= Y.GetHashCode();
    if (Z != 0D) hash ^= Z.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (X != 0D) {
      output.WriteRawTag(9);
      output.WriteDouble(X);
    }
    if (Y != 0D) {
      output.WriteRawTag(17);
      output.WriteDouble(Y);
    }
    if (Z != 0D) {
      output.WriteRawTag(25);
      output.WriteDouble(Z);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (X != 0D) {
      size += 1 + 8;
    }
    if (Y != 0D) {
      size += 1 + 8;
    }
    if (Z != 0D) {
      size += 1 + 8;
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Vector3 other) {
    if (other == null) {
      return;
    }
    if (other.X != 0D) {
      X = other.X;
    }
    if (other.Y != 0D) {
      Y = other.Y;
    }
    if (other.Z != 0D) {
      Z = other.Z;
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
        case 9: {
          X = input.ReadDouble();
          break;
        }
        case 17: {
          Y = input.ReadDouble();
          break;
        }
        case 25: {
          Z = input.ReadDouble();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
