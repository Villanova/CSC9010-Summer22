// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/ordering.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcOrdering {

  /// <summary>Holder for reflection information generated from Proto/ordering.proto</summary>
  public static partial class OrderingReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/ordering.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OrderingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcm90by9vcmRlcmluZy5wcm90bxILT3JkZXJpbmdBcGkiUgoXQ3JlYXRl",
            "T3JkZXJEcmFmdENvbW1hbmQSDwoHYnV5ZXJJZBgBIAEoCRImCgVpdGVtcxgC",
            "IAMoCzIXLk9yZGVyaW5nQXBpLkJhc2tldEl0ZW0ijwEKCkJhc2tldEl0ZW0S",
            "CgoCaWQYASABKAkSEQoJcHJvZHVjdElkGAIgASgFEhMKC3Byb2R1Y3ROYW1l",
            "GAMgASgJEhEKCXVuaXRQcmljZRgEIAEoARIUCgxvbGRVbml0UHJpY2UYBSAB",
            "KAESEAoIcXVhbnRpdHkYBiABKAUSEgoKcGljdHVyZVVybBgHIAEoCSJNCg1P",
            "cmRlckRyYWZ0RFRPEg0KBXRvdGFsGAEgASgBEi0KCm9yZGVySXRlbXMYAiAD",
            "KAsyGS5PcmRlcmluZ0FwaS5PcmRlckl0ZW1EVE8ifgoMT3JkZXJJdGVtRFRP",
            "EhEKCXByb2R1Y3RJZBgBIAEoBRITCgtwcm9kdWN0TmFtZRgCIAEoCRIRCgl1",
            "bml0UHJpY2UYAyABKAESEAoIZGlzY291bnQYBCABKAESDQoFdW5pdHMYBSAB",
            "KAUSEgoKcGljdHVyZVVybBgGIAEoCTJ0CgxPcmRlcmluZ0dycGMSZAoeQ3Jl",
            "YXRlT3JkZXJEcmFmdEZyb21CYXNrZXREYXRhEiQuT3JkZXJpbmdBcGkuQ3Jl",
            "YXRlT3JkZXJEcmFmdENvbW1hbmQaGi5PcmRlcmluZ0FwaS5PcmRlckRyYWZ0",
            "RFRPIgBCD6oCDEdycGNPcmRlcmluZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcOrdering.CreateOrderDraftCommand), global::GrpcOrdering.CreateOrderDraftCommand.Parser, new[]{ "BuyerId", "Items" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcOrdering.BasketItem), global::GrpcOrdering.BasketItem.Parser, new[]{ "Id", "ProductId", "ProductName", "UnitPrice", "OldUnitPrice", "Quantity", "PictureUrl" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcOrdering.OrderDraftDTO), global::GrpcOrdering.OrderDraftDTO.Parser, new[]{ "Total", "OrderItems" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcOrdering.OrderItemDTO), global::GrpcOrdering.OrderItemDTO.Parser, new[]{ "ProductId", "ProductName", "UnitPrice", "Discount", "Units", "PictureUrl" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CreateOrderDraftCommand : pb::IMessage<CreateOrderDraftCommand>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateOrderDraftCommand> _parser = new pb::MessageParser<CreateOrderDraftCommand>(() => new CreateOrderDraftCommand());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CreateOrderDraftCommand> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcOrdering.OrderingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateOrderDraftCommand() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateOrderDraftCommand(CreateOrderDraftCommand other) : this() {
      buyerId_ = other.buyerId_;
      items_ = other.items_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CreateOrderDraftCommand Clone() {
      return new CreateOrderDraftCommand(this);
    }

    /// <summary>Field number for the "buyerId" field.</summary>
    public const int BuyerIdFieldNumber = 1;
    private string buyerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BuyerId {
      get { return buyerId_; }
      set {
        buyerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::GrpcOrdering.BasketItem> _repeated_items_codec
        = pb::FieldCodec.ForMessage(18, global::GrpcOrdering.BasketItem.Parser);
    private readonly pbc::RepeatedField<global::GrpcOrdering.BasketItem> items_ = new pbc::RepeatedField<global::GrpcOrdering.BasketItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcOrdering.BasketItem> Items {
      get { return items_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CreateOrderDraftCommand);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CreateOrderDraftCommand other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuyerId != other.BuyerId) return false;
      if(!items_.Equals(other.items_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BuyerId.Length != 0) hash ^= BuyerId.GetHashCode();
      hash ^= items_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (BuyerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BuyerId);
      }
      items_.WriteTo(output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BuyerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BuyerId);
      }
      items_.WriteTo(ref output, _repeated_items_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BuyerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BuyerId);
      }
      size += items_.CalculateSize(_repeated_items_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CreateOrderDraftCommand other) {
      if (other == null) {
        return;
      }
      if (other.BuyerId.Length != 0) {
        BuyerId = other.BuyerId;
      }
      items_.Add(other.items_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            BuyerId = input.ReadString();
            break;
          }
          case 18: {
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            BuyerId = input.ReadString();
            break;
          }
          case 18: {
            items_.AddEntriesFrom(ref input, _repeated_items_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class BasketItem : pb::IMessage<BasketItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BasketItem> _parser = new pb::MessageParser<BasketItem>(() => new BasketItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BasketItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcOrdering.OrderingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketItem(BasketItem other) : this() {
      id_ = other.id_;
      productId_ = other.productId_;
      productName_ = other.productName_;
      unitPrice_ = other.unitPrice_;
      oldUnitPrice_ = other.oldUnitPrice_;
      quantity_ = other.quantity_;
      pictureUrl_ = other.pictureUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BasketItem Clone() {
      return new BasketItem(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "productId" field.</summary>
    public const int ProductIdFieldNumber = 2;
    private int productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ProductId {
      get { return productId_; }
      set {
        productId_ = value;
      }
    }

    /// <summary>Field number for the "productName" field.</summary>
    public const int ProductNameFieldNumber = 3;
    private string productName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProductName {
      get { return productName_; }
      set {
        productName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unitPrice" field.</summary>
    public const int UnitPriceFieldNumber = 4;
    private double unitPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double UnitPrice {
      get { return unitPrice_; }
      set {
        unitPrice_ = value;
      }
    }

    /// <summary>Field number for the "oldUnitPrice" field.</summary>
    public const int OldUnitPriceFieldNumber = 5;
    private double oldUnitPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double OldUnitPrice {
      get { return oldUnitPrice_; }
      set {
        oldUnitPrice_ = value;
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 6;
    private int quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    /// <summary>Field number for the "pictureUrl" field.</summary>
    public const int PictureUrlFieldNumber = 7;
    private string pictureUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PictureUrl {
      get { return pictureUrl_; }
      set {
        pictureUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BasketItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BasketItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (ProductId != other.ProductId) return false;
      if (ProductName != other.ProductName) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UnitPrice, other.UnitPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(OldUnitPrice, other.OldUnitPrice)) return false;
      if (Quantity != other.Quantity) return false;
      if (PictureUrl != other.PictureUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (ProductId != 0) hash ^= ProductId.GetHashCode();
      if (ProductName.Length != 0) hash ^= ProductName.GetHashCode();
      if (UnitPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UnitPrice);
      if (OldUnitPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(OldUnitPrice);
      if (Quantity != 0) hash ^= Quantity.GetHashCode();
      if (PictureUrl.Length != 0) hash ^= PictureUrl.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (ProductId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductName);
      }
      if (UnitPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(UnitPrice);
      }
      if (OldUnitPrice != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(OldUnitPrice);
      }
      if (Quantity != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Quantity);
      }
      if (PictureUrl.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PictureUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (ProductId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductName);
      }
      if (UnitPrice != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(UnitPrice);
      }
      if (OldUnitPrice != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(OldUnitPrice);
      }
      if (Quantity != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Quantity);
      }
      if (PictureUrl.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PictureUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (ProductId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProductId);
      }
      if (ProductName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductName);
      }
      if (UnitPrice != 0D) {
        size += 1 + 8;
      }
      if (OldUnitPrice != 0D) {
        size += 1 + 8;
      }
      if (Quantity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Quantity);
      }
      if (PictureUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PictureUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BasketItem other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.ProductId != 0) {
        ProductId = other.ProductId;
      }
      if (other.ProductName.Length != 0) {
        ProductName = other.ProductName;
      }
      if (other.UnitPrice != 0D) {
        UnitPrice = other.UnitPrice;
      }
      if (other.OldUnitPrice != 0D) {
        OldUnitPrice = other.OldUnitPrice;
      }
      if (other.Quantity != 0) {
        Quantity = other.Quantity;
      }
      if (other.PictureUrl.Length != 0) {
        PictureUrl = other.PictureUrl;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            Id = input.ReadString();
            break;
          }
          case 16: {
            ProductId = input.ReadInt32();
            break;
          }
          case 26: {
            ProductName = input.ReadString();
            break;
          }
          case 33: {
            UnitPrice = input.ReadDouble();
            break;
          }
          case 41: {
            OldUnitPrice = input.ReadDouble();
            break;
          }
          case 48: {
            Quantity = input.ReadInt32();
            break;
          }
          case 58: {
            PictureUrl = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            ProductId = input.ReadInt32();
            break;
          }
          case 26: {
            ProductName = input.ReadString();
            break;
          }
          case 33: {
            UnitPrice = input.ReadDouble();
            break;
          }
          case 41: {
            OldUnitPrice = input.ReadDouble();
            break;
          }
          case 48: {
            Quantity = input.ReadInt32();
            break;
          }
          case 58: {
            PictureUrl = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class OrderDraftDTO : pb::IMessage<OrderDraftDTO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OrderDraftDTO> _parser = new pb::MessageParser<OrderDraftDTO>(() => new OrderDraftDTO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OrderDraftDTO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcOrdering.OrderingReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderDraftDTO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderDraftDTO(OrderDraftDTO other) : this() {
      total_ = other.total_;
      orderItems_ = other.orderItems_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderDraftDTO Clone() {
      return new OrderDraftDTO(this);
    }

    /// <summary>Field number for the "total" field.</summary>
    public const int TotalFieldNumber = 1;
    private double total_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Total {
      get { return total_; }
      set {
        total_ = value;
      }
    }

    /// <summary>Field number for the "orderItems" field.</summary>
    public const int OrderItemsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::GrpcOrdering.OrderItemDTO> _repeated_orderItems_codec
        = pb::FieldCodec.ForMessage(18, global::GrpcOrdering.OrderItemDTO.Parser);
    private readonly pbc::RepeatedField<global::GrpcOrdering.OrderItemDTO> orderItems_ = new pbc::RepeatedField<global::GrpcOrdering.OrderItemDTO>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::GrpcOrdering.OrderItemDTO> OrderItems {
      get { return orderItems_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OrderDraftDTO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OrderDraftDTO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Total, other.Total)) return false;
      if(!orderItems_.Equals(other.orderItems_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Total != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Total);
      hash ^= orderItems_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Total != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Total);
      }
      orderItems_.WriteTo(output, _repeated_orderItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Total != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(Total);
      }
      orderItems_.WriteTo(ref output, _repeated_orderItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Total != 0D) {
        size += 1 + 8;
      }
      size += orderItems_.CalculateSize(_repeated_orderItems_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OrderDraftDTO other) {
      if (other == null) {
        return;
      }
      if (other.Total != 0D) {
        Total = other.Total;
      }
      orderItems_.Add(other.orderItems_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 9: {
            Total = input.ReadDouble();
            break;
          }
          case 18: {
            orderItems_.AddEntriesFrom(input, _repeated_orderItems_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 9: {
            Total = input.ReadDouble();
            break;
          }
          case 18: {
            orderItems_.AddEntriesFrom(ref input, _repeated_orderItems_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class OrderItemDTO : pb::IMessage<OrderItemDTO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OrderItemDTO> _parser = new pb::MessageParser<OrderItemDTO>(() => new OrderItemDTO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OrderItemDTO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcOrdering.OrderingReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderItemDTO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderItemDTO(OrderItemDTO other) : this() {
      productId_ = other.productId_;
      productName_ = other.productName_;
      unitPrice_ = other.unitPrice_;
      discount_ = other.discount_;
      units_ = other.units_;
      pictureUrl_ = other.pictureUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OrderItemDTO Clone() {
      return new OrderItemDTO(this);
    }

    /// <summary>Field number for the "productId" field.</summary>
    public const int ProductIdFieldNumber = 1;
    private int productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ProductId {
      get { return productId_; }
      set {
        productId_ = value;
      }
    }

    /// <summary>Field number for the "productName" field.</summary>
    public const int ProductNameFieldNumber = 2;
    private string productName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProductName {
      get { return productName_; }
      set {
        productName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "unitPrice" field.</summary>
    public const int UnitPriceFieldNumber = 3;
    private double unitPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double UnitPrice {
      get { return unitPrice_; }
      set {
        unitPrice_ = value;
      }
    }

    /// <summary>Field number for the "discount" field.</summary>
    public const int DiscountFieldNumber = 4;
    private double discount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Discount {
      get { return discount_; }
      set {
        discount_ = value;
      }
    }

    /// <summary>Field number for the "units" field.</summary>
    public const int UnitsFieldNumber = 5;
    private int units_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Units {
      get { return units_; }
      set {
        units_ = value;
      }
    }

    /// <summary>Field number for the "pictureUrl" field.</summary>
    public const int PictureUrlFieldNumber = 6;
    private string pictureUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PictureUrl {
      get { return pictureUrl_; }
      set {
        pictureUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OrderItemDTO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OrderItemDTO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (ProductName != other.ProductName) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(UnitPrice, other.UnitPrice)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Discount, other.Discount)) return false;
      if (Units != other.Units) return false;
      if (PictureUrl != other.PictureUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ProductId != 0) hash ^= ProductId.GetHashCode();
      if (ProductName.Length != 0) hash ^= ProductName.GetHashCode();
      if (UnitPrice != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(UnitPrice);
      if (Discount != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Discount);
      if (Units != 0) hash ^= Units.GetHashCode();
      if (PictureUrl.Length != 0) hash ^= PictureUrl.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ProductId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductName);
      }
      if (UnitPrice != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(UnitPrice);
      }
      if (Discount != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Discount);
      }
      if (Units != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Units);
      }
      if (PictureUrl.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PictureUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ProductId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ProductId);
      }
      if (ProductName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductName);
      }
      if (UnitPrice != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(UnitPrice);
      }
      if (Discount != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Discount);
      }
      if (Units != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Units);
      }
      if (PictureUrl.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PictureUrl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ProductId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ProductId);
      }
      if (ProductName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductName);
      }
      if (UnitPrice != 0D) {
        size += 1 + 8;
      }
      if (Discount != 0D) {
        size += 1 + 8;
      }
      if (Units != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Units);
      }
      if (PictureUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PictureUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OrderItemDTO other) {
      if (other == null) {
        return;
      }
      if (other.ProductId != 0) {
        ProductId = other.ProductId;
      }
      if (other.ProductName.Length != 0) {
        ProductName = other.ProductName;
      }
      if (other.UnitPrice != 0D) {
        UnitPrice = other.UnitPrice;
      }
      if (other.Discount != 0D) {
        Discount = other.Discount;
      }
      if (other.Units != 0) {
        Units = other.Units;
      }
      if (other.PictureUrl.Length != 0) {
        PictureUrl = other.PictureUrl;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 8: {
            ProductId = input.ReadInt32();
            break;
          }
          case 18: {
            ProductName = input.ReadString();
            break;
          }
          case 25: {
            UnitPrice = input.ReadDouble();
            break;
          }
          case 33: {
            Discount = input.ReadDouble();
            break;
          }
          case 40: {
            Units = input.ReadInt32();
            break;
          }
          case 50: {
            PictureUrl = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ProductId = input.ReadInt32();
            break;
          }
          case 18: {
            ProductName = input.ReadString();
            break;
          }
          case 25: {
            UnitPrice = input.ReadDouble();
            break;
          }
          case 33: {
            Discount = input.ReadDouble();
            break;
          }
          case 40: {
            Units = input.ReadInt32();
            break;
          }
          case 50: {
            PictureUrl = input.ReadString();
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