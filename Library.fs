module rec Library
open System
open System.Diagnostics
open type System.Text.Encoding
open System.Runtime.InteropServices

open System.Runtime.InteropServices
type GDExtensionClassInstancePtr = nativeint
type uintmax_t = uint64
type intmax_t = int64
type uint_fast64_t = uint64
type uint_fast32_t = uint
type uint_fast16_t = uint
type uint_fast8_t = byte
type int_fast64_t = int64
type int_fast32_t = int
type int_fast16_t = int
type int_fast8_t = sbyte
type uint_least64_t = uint64
type uint_least32_t = uint
type uint_least16_t = uint16
type uint_least8_t = byte
type int_least64_t = int64
type int_least32_t = int
type int_least16_t = int16
type char32_t = uint32_t
type char16_t = uint16_t
type GDExtensionBool = uint8_t
type GDExtensionInt = int64_t
type GDExtensionMethodBindPtr = nativeint
type GDExtensionUninitializedTypePtr = nativeint
type GDExtensionConstTypePtr = nativeint
type GDExtensionTypePtr = nativeint
type GDExtensionUninitializedObjectPtr = nativeint
type GDExtensionConstObjectPtr = nativeint
type int_least8_t = sbyte
type GDExtensionObjectPtr = nativeint
type GDExtensionConstStringPtr = nativeint
type GDExtensionStringPtr = nativeint
type GDExtensionUninitializedStringNamePtr = nativeint
type GDExtensionConstStringNamePtr = nativeint
type GDExtensionStringNamePtr = nativeint
type GDExtensionUninitializedVariantPtr = nativeint
type GDExtensionConstVariantPtr = nativeint
type GDExtensionVariantPtr = nativeint
type GDExtensionUninitializedStringPtr = nativeint
type GDObjectInstanceID = uint64_t
type uint64_t = uint64
type uint16_t = uint16
type GDExtensionClassLibraryPtr = nativeint
type GDExtensionScriptInstanceDataPtr = nativeint
type GDExtensionScriptLanguagePtr = nativeint
type GDExtensionScriptInstancePtr = nativeint
type GDExtensionConstRefPtr = nativeint
type uint8_t = byte
type int64_t = int64
type int32_t = int
type int16_t = int16
type int8_t = sbyte
type __vcrt_bool = bool
type intptr_t = int64
type va_list = nativeptr<char>
type uint32_t = uint
type uintptr_t = uint64
type wchar_t = uint16
type ptrdiff_t = int64
type __builtin_ms_va_list = nativeptr<char>
type size_t = uint64
type max_align_t = double
type GDExtensionRefPtr = nativeint
type GDExtensionVariantType =
    | GDEXTENSION_VARIANT_TYPE_NIL = 0
    | GDEXTENSION_VARIANT_TYPE_BOOL = 1
    | GDEXTENSION_VARIANT_TYPE_INT = 2
    | GDEXTENSION_VARIANT_TYPE_FLOAT = 3
    | GDEXTENSION_VARIANT_TYPE_STRING = 4
    | GDEXTENSION_VARIANT_TYPE_VECTOR2 = 5
    | GDEXTENSION_VARIANT_TYPE_VECTOR2I = 6
    | GDEXTENSION_VARIANT_TYPE_RECT2 = 7
    | GDEXTENSION_VARIANT_TYPE_RECT2I = 8
    | GDEXTENSION_VARIANT_TYPE_VECTOR3 = 9
    | GDEXTENSION_VARIANT_TYPE_VECTOR3I = 10
    | GDEXTENSION_VARIANT_TYPE_TRANSFORM2D = 11
    | GDEXTENSION_VARIANT_TYPE_VECTOR4 = 12
    | GDEXTENSION_VARIANT_TYPE_VECTOR4I = 13
    | GDEXTENSION_VARIANT_TYPE_PLANE = 14
    | GDEXTENSION_VARIANT_TYPE_QUATERNION = 15
    | GDEXTENSION_VARIANT_TYPE_AABB = 16
    | GDEXTENSION_VARIANT_TYPE_BASIS = 17
    | GDEXTENSION_VARIANT_TYPE_TRANSFORM3D = 18
    | GDEXTENSION_VARIANT_TYPE_PROJECTION = 19
    | GDEXTENSION_VARIANT_TYPE_COLOR = 20
    | GDEXTENSION_VARIANT_TYPE_STRING_NAME = 21
    | GDEXTENSION_VARIANT_TYPE_NODE_PATH = 22
    | GDEXTENSION_VARIANT_TYPE_RID = 23
    | GDEXTENSION_VARIANT_TYPE_OBJECT = 24
    | GDEXTENSION_VARIANT_TYPE_CALLABLE = 25
    | GDEXTENSION_VARIANT_TYPE_SIGNAL = 26
    | GDEXTENSION_VARIANT_TYPE_DICTIONARY = 27
    | GDEXTENSION_VARIANT_TYPE_ARRAY = 28
    | GDEXTENSION_VARIANT_TYPE_PACKED_BYTE_ARRAY = 29
    | GDEXTENSION_VARIANT_TYPE_PACKED_INT32_ARRAY = 30
    | GDEXTENSION_VARIANT_TYPE_PACKED_INT64_ARRAY = 31
    | GDEXTENSION_VARIANT_TYPE_PACKED_FLOAT32_ARRAY = 32
    | GDEXTENSION_VARIANT_TYPE_PACKED_FLOAT64_ARRAY = 33
    | GDEXTENSION_VARIANT_TYPE_PACKED_STRING_ARRAY = 34
    | GDEXTENSION_VARIANT_TYPE_PACKED_VECTOR2_ARRAY = 35
    | GDEXTENSION_VARIANT_TYPE_PACKED_VECTOR3_ARRAY = 36
    | GDEXTENSION_VARIANT_TYPE_PACKED_COLOR_ARRAY = 37
    | GDEXTENSION_VARIANT_TYPE_VARIANT_MAX = 38
type GDExtensionVariantOperator =
    | GDEXTENSION_VARIANT_OP_EQUAL = 0
    | GDEXTENSION_VARIANT_OP_NOT_EQUAL = 1
    | GDEXTENSION_VARIANT_OP_LESS = 2
    | GDEXTENSION_VARIANT_OP_LESS_EQUAL = 3
    | GDEXTENSION_VARIANT_OP_GREATER = 4
    | GDEXTENSION_VARIANT_OP_GREATER_EQUAL = 5
    | GDEXTENSION_VARIANT_OP_ADD = 6
    | GDEXTENSION_VARIANT_OP_SUBTRACT = 7
    | GDEXTENSION_VARIANT_OP_MULTIPLY = 8
    | GDEXTENSION_VARIANT_OP_DIVIDE = 9
    | GDEXTENSION_VARIANT_OP_NEGATE = 10
    | GDEXTENSION_VARIANT_OP_POSITIVE = 11
    | GDEXTENSION_VARIANT_OP_MODULE = 12
    | GDEXTENSION_VARIANT_OP_POWER = 13
    | GDEXTENSION_VARIANT_OP_SHIFT_LEFT = 14
    | GDEXTENSION_VARIANT_OP_SHIFT_RIGHT = 15
    | GDEXTENSION_VARIANT_OP_BIT_AND = 16
    | GDEXTENSION_VARIANT_OP_BIT_OR = 17
    | GDEXTENSION_VARIANT_OP_BIT_XOR = 18
    | GDEXTENSION_VARIANT_OP_BIT_NEGATE = 19
    | GDEXTENSION_VARIANT_OP_AND = 20
    | GDEXTENSION_VARIANT_OP_OR = 21
    | GDEXTENSION_VARIANT_OP_XOR = 22
    | GDEXTENSION_VARIANT_OP_NOT = 23
    | GDEXTENSION_VARIANT_OP_IN = 24
    | GDEXTENSION_VARIANT_OP_MAX = 25
type GDExtensionCallErrorType =
    | GDEXTENSION_CALL_OK = 0
    | GDEXTENSION_CALL_ERROR_INVALID_METHOD = 1
    | GDEXTENSION_CALL_ERROR_INVALID_ARGUMENT = 2
    | GDEXTENSION_CALL_ERROR_TOO_MANY_ARGUMENTS = 3
    | GDEXTENSION_CALL_ERROR_TOO_FEW_ARGUMENTS = 4
    | GDEXTENSION_CALL_ERROR_INSTANCE_IS_NULL = 5
    | GDEXTENSION_CALL_ERROR_METHOD_NOT_CONST = 6
type GDExtensionClassMethodFlags =
    | GDEXTENSION_METHOD_FLAG_NORMAL = 1
    | GDEXTENSION_METHOD_FLAG_EDITOR = 2
    | GDEXTENSION_METHOD_FLAG_CONST = 4
    | GDEXTENSION_METHOD_FLAG_VIRTUAL = 8
    | GDEXTENSION_METHOD_FLAG_VARARG = 16
    | GDEXTENSION_METHOD_FLAG_STATIC = 32
    | GDEXTENSION_METHOD_FLAGS_DEFAULT = 1
type GDExtensionClassMethodArgumentMetadata =
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_NONE = 0
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_INT_IS_INT8 = 1
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_INT_IS_INT16 = 2
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_INT_IS_INT32 = 3
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_INT_IS_INT64 = 4
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_INT_IS_UINT8 = 5
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_INT_IS_UINT16 = 6
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_INT_IS_UINT32 = 7
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_INT_IS_UINT64 = 8
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_REAL_IS_FLOAT = 9
    | GDEXTENSION_METHOD_ARGUMENT_METADATA_REAL_IS_DOUBLE = 10
type GDExtensionInitializationLevel =
    | GDEXTENSION_INITIALIZATION_CORE = 0
    | GDEXTENSION_INITIALIZATION_SERVERS = 1
    | GDEXTENSION_INITIALIZATION_SCENE = 2
    | GDEXTENSION_INITIALIZATION_EDITOR = 3
    | GDEXTENSION_MAX_INITIALIZATION_LEVEL = 4
type GDExtensionClassCreationInfo2_SafeInit = {
    is_virtual: GDExtensionBool
    is_abstract: GDExtensionBool
    is_exposed: GDExtensionBool
    set_func: GDExtensionClassSet
    get_func: GDExtensionClassGet
    get_property_list_func: GDExtensionClassGetPropertyList
    free_property_list_func: GDExtensionClassFreePropertyList
    property_can_revert_func: GDExtensionClassPropertyCanRevert
    property_get_revert_func: GDExtensionClassPropertyGetRevert
    validate_property_func: GDExtensionClassValidateProperty
    notification_func: GDExtensionClassNotification2
    to_string_func: GDExtensionClassToString
    reference_func: GDExtensionClassReference
    unreference_func: GDExtensionClassUnreference
    create_instance_func: GDExtensionClassCreateInstance
    free_instance_func: GDExtensionClassFreeInstance
    recreate_instance_func: GDExtensionClassRecreateInstance
    get_virtual_func: GDExtensionClassGetVirtual
    get_virtual_call_data_func: GDExtensionClassGetVirtualCallData
    call_virtual_with_data_func: GDExtensionClassCallVirtualWithData
    get_rid_func: GDExtensionClassGetRID
    class_userdata: nativeint
}
type [<Struct>] GDExtensionClassCreationInfo2 = {
    is_virtual: GDExtensionBool
    is_abstract: GDExtensionBool
    is_exposed: GDExtensionBool
    set_func: nativeint (* GDExtensionClassSet: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> GDExtensionBool *)
    get_func: nativeint (* GDExtensionClassGet: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    get_property_list_func: nativeint (* GDExtensionClassGetPropertyList: delegate of GDExtensionClassInstancePtr * nativeptr<uint32_t> -> nativeptr<GDExtensionPropertyInfo> *)
    free_property_list_func: nativeint (* GDExtensionClassFreePropertyList: delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionPropertyInfo> -> unit *)
    property_can_revert_func: nativeint (* GDExtensionClassPropertyCanRevert: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr -> GDExtensionBool *)
    property_get_revert_func: nativeint (* GDExtensionClassPropertyGetRevert: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    validate_property_func: nativeint (* GDExtensionClassValidateProperty: delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionPropertyInfo> -> GDExtensionBool *)
    notification_func: nativeint (* GDExtensionClassNotification2: delegate of GDExtensionClassInstancePtr * int32_t * GDExtensionBool -> unit *)
    to_string_func: nativeint (* GDExtensionClassToString: delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionBool> * GDExtensionStringPtr -> unit *)
    reference_func: nativeint (* GDExtensionClassReference: delegate of GDExtensionClassInstancePtr -> unit *)
    unreference_func: nativeint (* GDExtensionClassUnreference: delegate of GDExtensionClassInstancePtr -> unit *)
    create_instance_func: nativeint (* GDExtensionClassCreateInstance: delegate of nativeint -> GDExtensionObjectPtr *)
    free_instance_func: nativeint (* GDExtensionClassFreeInstance: delegate of nativeint * GDExtensionClassInstancePtr -> unit *)
    recreate_instance_func: nativeint (* GDExtensionClassRecreateInstance: delegate of nativeint * GDExtensionObjectPtr -> GDExtensionClassInstancePtr *)
    get_virtual_func: nativeint (* GDExtensionClassGetVirtual: delegate of nativeint * GDExtensionConstStringNamePtr -> GDExtensionClassCallVirtual *)
    get_virtual_call_data_func: nativeint (* GDExtensionClassGetVirtualCallData: delegate of nativeint * GDExtensionConstStringNamePtr -> nativeint *)
    call_virtual_with_data_func: nativeint (* GDExtensionClassCallVirtualWithData: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * nativeint * nativeptr<GDExtensionConstTypePtr> * GDExtensionTypePtr -> unit *)
    get_rid_func: nativeint (* GDExtensionClassGetRID: delegate of GDExtensionClassInstancePtr -> uint64_t *)
    class_userdata: nativeint
} with
    static member Init (init: GDExtensionClassCreationInfo2_SafeInit) : GDExtensionClassCreationInfo2 =
        {
            is_virtual = init.is_virtual
            is_abstract = init.is_abstract
            is_exposed = init.is_exposed
            set_func = Marshal.GetFunctionPointerForDelegate(init.set_func)
            get_func = Marshal.GetFunctionPointerForDelegate(init.get_func)
            get_property_list_func = Marshal.GetFunctionPointerForDelegate(init.get_property_list_func)
            free_property_list_func = Marshal.GetFunctionPointerForDelegate(init.free_property_list_func)
            property_can_revert_func = Marshal.GetFunctionPointerForDelegate(init.property_can_revert_func)
            property_get_revert_func = Marshal.GetFunctionPointerForDelegate(init.property_get_revert_func)
            validate_property_func = Marshal.GetFunctionPointerForDelegate(init.validate_property_func)
            notification_func = Marshal.GetFunctionPointerForDelegate(init.notification_func)
            to_string_func = Marshal.GetFunctionPointerForDelegate(init.to_string_func)
            reference_func = Marshal.GetFunctionPointerForDelegate(init.reference_func)
            unreference_func = Marshal.GetFunctionPointerForDelegate(init.unreference_func)
            create_instance_func = Marshal.GetFunctionPointerForDelegate(init.create_instance_func)
            free_instance_func = Marshal.GetFunctionPointerForDelegate(init.free_instance_func)
            recreate_instance_func = Marshal.GetFunctionPointerForDelegate(init.recreate_instance_func)
            get_virtual_func = Marshal.GetFunctionPointerForDelegate(init.get_virtual_func)
            get_virtual_call_data_func = Marshal.GetFunctionPointerForDelegate(init.get_virtual_call_data_func)
            call_virtual_with_data_func = Marshal.GetFunctionPointerForDelegate(init.call_virtual_with_data_func)
            get_rid_func = Marshal.GetFunctionPointerForDelegate(init.get_rid_func)
            class_userdata = init.class_userdata
        }
type GDExtensionClassCreationInfo_SafeInit = {
    is_virtual: GDExtensionBool
    is_abstract: GDExtensionBool
    set_func: GDExtensionClassSet
    get_func: GDExtensionClassGet
    get_property_list_func: GDExtensionClassGetPropertyList
    free_property_list_func: GDExtensionClassFreePropertyList
    property_can_revert_func: GDExtensionClassPropertyCanRevert
    property_get_revert_func: GDExtensionClassPropertyGetRevert
    notification_func: GDExtensionClassNotification
    to_string_func: GDExtensionClassToString
    reference_func: GDExtensionClassReference
    unreference_func: GDExtensionClassUnreference
    create_instance_func: GDExtensionClassCreateInstance
    free_instance_func: GDExtensionClassFreeInstance
    get_virtual_func: GDExtensionClassGetVirtual
    get_rid_func: GDExtensionClassGetRID
    class_userdata: nativeint
}
type [<Struct>] GDExtensionClassCreationInfo = {
    is_virtual: GDExtensionBool
    is_abstract: GDExtensionBool
    set_func: nativeint (* GDExtensionClassSet: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> GDExtensionBool *)
    get_func: nativeint (* GDExtensionClassGet: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    get_property_list_func: nativeint (* GDExtensionClassGetPropertyList: delegate of GDExtensionClassInstancePtr * nativeptr<uint32_t> -> nativeptr<GDExtensionPropertyInfo> *)
    free_property_list_func: nativeint (* GDExtensionClassFreePropertyList: delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionPropertyInfo> -> unit *)
    property_can_revert_func: nativeint (* GDExtensionClassPropertyCanRevert: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr -> GDExtensionBool *)
    property_get_revert_func: nativeint (* GDExtensionClassPropertyGetRevert: delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    notification_func: nativeint (* GDExtensionClassNotification: delegate of GDExtensionClassInstancePtr * int32_t -> unit *)
    to_string_func: nativeint (* GDExtensionClassToString: delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionBool> * GDExtensionStringPtr -> unit *)
    reference_func: nativeint (* GDExtensionClassReference: delegate of GDExtensionClassInstancePtr -> unit *)
    unreference_func: nativeint (* GDExtensionClassUnreference: delegate of GDExtensionClassInstancePtr -> unit *)
    create_instance_func: nativeint (* GDExtensionClassCreateInstance: delegate of nativeint -> GDExtensionObjectPtr *)
    free_instance_func: nativeint (* GDExtensionClassFreeInstance: delegate of nativeint * GDExtensionClassInstancePtr -> unit *)
    get_virtual_func: nativeint (* GDExtensionClassGetVirtual: delegate of nativeint * GDExtensionConstStringNamePtr -> GDExtensionClassCallVirtual *)
    get_rid_func: nativeint (* GDExtensionClassGetRID: delegate of GDExtensionClassInstancePtr -> uint64_t *)
    class_userdata: nativeint
} with
    static member Init (init: GDExtensionClassCreationInfo_SafeInit) : GDExtensionClassCreationInfo =
        {
            is_virtual = init.is_virtual
            is_abstract = init.is_abstract
            set_func = Marshal.GetFunctionPointerForDelegate(init.set_func)
            get_func = Marshal.GetFunctionPointerForDelegate(init.get_func)
            get_property_list_func = Marshal.GetFunctionPointerForDelegate(init.get_property_list_func)
            free_property_list_func = Marshal.GetFunctionPointerForDelegate(init.free_property_list_func)
            property_can_revert_func = Marshal.GetFunctionPointerForDelegate(init.property_can_revert_func)
            property_get_revert_func = Marshal.GetFunctionPointerForDelegate(init.property_get_revert_func)
            notification_func = Marshal.GetFunctionPointerForDelegate(init.notification_func)
            to_string_func = Marshal.GetFunctionPointerForDelegate(init.to_string_func)
            reference_func = Marshal.GetFunctionPointerForDelegate(init.reference_func)
            unreference_func = Marshal.GetFunctionPointerForDelegate(init.unreference_func)
            create_instance_func = Marshal.GetFunctionPointerForDelegate(init.create_instance_func)
            free_instance_func = Marshal.GetFunctionPointerForDelegate(init.free_instance_func)
            get_virtual_func = Marshal.GetFunctionPointerForDelegate(init.get_virtual_func)
            get_rid_func = Marshal.GetFunctionPointerForDelegate(init.get_rid_func)
            class_userdata = init.class_userdata
        }
type GDExtensionClassMethodInfo_SafeInit = {
    name: GDExtensionStringNamePtr
    method_userdata: nativeint
    call_func: GDExtensionClassMethodCall
    ptrcall_func: GDExtensionClassMethodPtrCall
    method_flags: uint32_t
    has_return_value: GDExtensionBool
    return_value_info: nativeptr<GDExtensionPropertyInfo>
    return_value_metadata: GDExtensionClassMethodArgumentMetadata
    argument_count: uint32_t
    arguments_info: nativeptr<GDExtensionPropertyInfo>
    arguments_metadata: nativeptr<GDExtensionClassMethodArgumentMetadata>
    default_argument_count: uint32_t
    default_arguments: nativeptr<GDExtensionVariantPtr>
}
type [<Struct>] GDExtensionClassMethodInfo = {
    name: GDExtensionStringNamePtr
    method_userdata: nativeint
    call_func: nativeint (* GDExtensionClassMethodCall: delegate of nativeint * GDExtensionClassInstancePtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionVariantPtr * nativeptr<GDExtensionCallError> -> unit *)
    ptrcall_func: nativeint (* GDExtensionClassMethodPtrCall: delegate of nativeint * GDExtensionClassInstancePtr * nativeptr<GDExtensionConstTypePtr> * GDExtensionTypePtr -> unit *)
    method_flags: uint32_t
    has_return_value: GDExtensionBool
    return_value_info: nativeptr<GDExtensionPropertyInfo>
    return_value_metadata: GDExtensionClassMethodArgumentMetadata
    argument_count: uint32_t
    arguments_info: nativeptr<GDExtensionPropertyInfo>
    arguments_metadata: nativeptr<GDExtensionClassMethodArgumentMetadata>
    default_argument_count: uint32_t
    default_arguments: nativeptr<GDExtensionVariantPtr>
} with
    static member Init (init: GDExtensionClassMethodInfo_SafeInit) : GDExtensionClassMethodInfo =
        {
            name = init.name
            method_userdata = init.method_userdata
            call_func = Marshal.GetFunctionPointerForDelegate(init.call_func)
            ptrcall_func = Marshal.GetFunctionPointerForDelegate(init.ptrcall_func)
            method_flags = init.method_flags
            has_return_value = init.has_return_value
            return_value_info = init.return_value_info
            return_value_metadata = init.return_value_metadata
            argument_count = init.argument_count
            arguments_info = init.arguments_info
            arguments_metadata = init.arguments_metadata
            default_argument_count = init.default_argument_count
            default_arguments = init.default_arguments
        }
type GDExtensionCallableCustomInfo_SafeInit = {
    callable_userdata: nativeint
    token: nativeint
    object_id: GDObjectInstanceID
    call_func: GDExtensionCallableCustomCall
    is_valid_func: GDExtensionCallableCustomIsValid
    free_func: GDExtensionCallableCustomFree
    hash_func: GDExtensionCallableCustomHash
    equal_func: GDExtensionCallableCustomEqual
    less_than_func: GDExtensionCallableCustomLessThan
    to_string_func: GDExtensionCallableCustomToString
}
type [<Struct>] GDExtensionCallableCustomInfo = {
    callable_userdata: nativeint
    token: nativeint
    object_id: GDObjectInstanceID
    call_func: nativeint (* GDExtensionCallableCustomCall: delegate of nativeint * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionVariantPtr * nativeptr<GDExtensionCallError> -> unit *)
    is_valid_func: nativeint (* GDExtensionCallableCustomIsValid: delegate of nativeint -> GDExtensionBool *)
    free_func: nativeint (* GDExtensionCallableCustomFree: delegate of nativeint -> unit *)
    hash_func: nativeint (* GDExtensionCallableCustomHash: delegate of nativeint -> uint32_t *)
    equal_func: nativeint (* GDExtensionCallableCustomEqual: delegate of nativeint * nativeint -> GDExtensionBool *)
    less_than_func: nativeint (* GDExtensionCallableCustomLessThan: delegate of nativeint * nativeint -> GDExtensionBool *)
    to_string_func: nativeint (* GDExtensionCallableCustomToString: delegate of nativeint * nativeptr<GDExtensionBool> * GDExtensionStringPtr -> unit *)
} with
    static member Init (init: GDExtensionCallableCustomInfo_SafeInit) : GDExtensionCallableCustomInfo =
        {
            callable_userdata = init.callable_userdata
            token = init.token
            object_id = init.object_id
            call_func = Marshal.GetFunctionPointerForDelegate(init.call_func)
            is_valid_func = Marshal.GetFunctionPointerForDelegate(init.is_valid_func)
            free_func = Marshal.GetFunctionPointerForDelegate(init.free_func)
            hash_func = Marshal.GetFunctionPointerForDelegate(init.hash_func)
            equal_func = Marshal.GetFunctionPointerForDelegate(init.equal_func)
            less_than_func = Marshal.GetFunctionPointerForDelegate(init.less_than_func)
            to_string_func = Marshal.GetFunctionPointerForDelegate(init.to_string_func)
        }
type [<Struct>] GDExtensionMethodInfo = {
    name: GDExtensionStringNamePtr
    return_value: GDExtensionPropertyInfo
    flags: uint32_t
    id: int32_t
    argument_count: uint32_t
    arguments: nativeptr<GDExtensionPropertyInfo>
    default_argument_count: uint32_t
    default_arguments: nativeptr<GDExtensionVariantPtr>
}
type [<Struct>] GDExtensionPropertyInfo = {
    ``type``: GDExtensionVariantType
    name: GDExtensionStringNamePtr
    class_name: GDExtensionStringNamePtr
    hint: uint32_t
    hint_string: GDExtensionStringPtr
    usage: uint32_t
}
type GDExtensionInstanceBindingCallbacks_SafeInit = {
    create_callback: GDExtensionInstanceBindingCreateCallback
    free_callback: GDExtensionInstanceBindingFreeCallback
    reference_callback: GDExtensionInstanceBindingReferenceCallback
}
type [<Struct>] GDExtensionInstanceBindingCallbacks = {
    create_callback: nativeint (* GDExtensionInstanceBindingCreateCallback: delegate of nativeint * nativeint -> nativeint *)
    free_callback: nativeint (* GDExtensionInstanceBindingFreeCallback: delegate of nativeint * nativeint * nativeint -> unit *)
    reference_callback: nativeint (* GDExtensionInstanceBindingReferenceCallback: delegate of nativeint * nativeint * GDExtensionBool -> GDExtensionBool *)
} with
    static member Init (init: GDExtensionInstanceBindingCallbacks_SafeInit) : GDExtensionInstanceBindingCallbacks =
        {
            create_callback = Marshal.GetFunctionPointerForDelegate(init.create_callback)
            free_callback = Marshal.GetFunctionPointerForDelegate(init.free_callback)
            reference_callback = Marshal.GetFunctionPointerForDelegate(init.reference_callback)
        }
type GDExtensionScriptInstanceInfo_SafeInit = {
    set_func: GDExtensionScriptInstanceSet
    get_func: GDExtensionScriptInstanceGet
    get_property_list_func: GDExtensionScriptInstanceGetPropertyList
    free_property_list_func: GDExtensionScriptInstanceFreePropertyList
    property_can_revert_func: GDExtensionScriptInstancePropertyCanRevert
    property_get_revert_func: GDExtensionScriptInstancePropertyGetRevert
    get_owner_func: GDExtensionScriptInstanceGetOwner
    get_property_state_func: GDExtensionScriptInstanceGetPropertyState
    get_method_list_func: GDExtensionScriptInstanceGetMethodList
    free_method_list_func: GDExtensionScriptInstanceFreeMethodList
    get_property_type_func: GDExtensionScriptInstanceGetPropertyType
    has_method_func: GDExtensionScriptInstanceHasMethod
    call_func: GDExtensionScriptInstanceCall
    notification_func: GDExtensionScriptInstanceNotification
    to_string_func: GDExtensionScriptInstanceToString
    refcount_incremented_func: GDExtensionScriptInstanceRefCountIncremented
    refcount_decremented_func: GDExtensionScriptInstanceRefCountDecremented
    get_script_func: GDExtensionScriptInstanceGetScript
    is_placeholder_func: GDExtensionScriptInstanceIsPlaceholder
    set_fallback_func: GDExtensionScriptInstanceSet
    get_fallback_func: GDExtensionScriptInstanceGet
    get_language_func: GDExtensionScriptInstanceGetLanguage
    free_func: GDExtensionScriptInstanceFree
}
type [<Struct>] GDExtensionScriptInstanceInfo = {
    set_func: nativeint (* GDExtensionScriptInstanceSet: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> GDExtensionBool *)
    get_func: nativeint (* GDExtensionScriptInstanceGet: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    get_property_list_func: nativeint (* GDExtensionScriptInstanceGetPropertyList: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<uint32_t> -> nativeptr<GDExtensionPropertyInfo> *)
    free_property_list_func: nativeint (* GDExtensionScriptInstanceFreePropertyList: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionPropertyInfo> -> unit *)
    property_can_revert_func: nativeint (* GDExtensionScriptInstancePropertyCanRevert: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr -> GDExtensionBool *)
    property_get_revert_func: nativeint (* GDExtensionScriptInstancePropertyGetRevert: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    get_owner_func: nativeint (* GDExtensionScriptInstanceGetOwner: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionObjectPtr *)
    get_property_state_func: nativeint (* GDExtensionScriptInstanceGetPropertyState: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionScriptInstancePropertyStateAdd * nativeint -> unit *)
    get_method_list_func: nativeint (* GDExtensionScriptInstanceGetMethodList: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<uint32_t> -> nativeptr<GDExtensionMethodInfo> *)
    free_method_list_func: nativeint (* GDExtensionScriptInstanceFreeMethodList: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionMethodInfo> -> unit *)
    get_property_type_func: nativeint (* GDExtensionScriptInstanceGetPropertyType: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionBool> -> GDExtensionVariantType *)
    has_method_func: nativeint (* GDExtensionScriptInstanceHasMethod: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr -> GDExtensionBool *)
    call_func: nativeint (* GDExtensionScriptInstanceCall: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionVariantPtr * nativeptr<GDExtensionCallError> -> unit *)
    notification_func: nativeint (* GDExtensionScriptInstanceNotification: delegate of GDExtensionScriptInstanceDataPtr * int32_t -> unit *)
    to_string_func: nativeint (* GDExtensionScriptInstanceToString: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionBool> * GDExtensionStringPtr -> unit *)
    refcount_incremented_func: nativeint (* GDExtensionScriptInstanceRefCountIncremented: delegate of GDExtensionScriptInstanceDataPtr -> unit *)
    refcount_decremented_func: nativeint (* GDExtensionScriptInstanceRefCountDecremented: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionBool *)
    get_script_func: nativeint (* GDExtensionScriptInstanceGetScript: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionObjectPtr *)
    is_placeholder_func: nativeint (* GDExtensionScriptInstanceIsPlaceholder: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionBool *)
    set_fallback_func: nativeint (* GDExtensionScriptInstanceSet: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> GDExtensionBool *)
    get_fallback_func: nativeint (* GDExtensionScriptInstanceGet: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    get_language_func: nativeint (* GDExtensionScriptInstanceGetLanguage: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionScriptLanguagePtr *)
    free_func: nativeint (* GDExtensionScriptInstanceFree: delegate of GDExtensionScriptInstanceDataPtr -> unit *)
} with
    static member Init (init: GDExtensionScriptInstanceInfo_SafeInit) : GDExtensionScriptInstanceInfo =
        {
            set_func = Marshal.GetFunctionPointerForDelegate(init.set_func)
            get_func = Marshal.GetFunctionPointerForDelegate(init.get_func)
            get_property_list_func = Marshal.GetFunctionPointerForDelegate(init.get_property_list_func)
            free_property_list_func = Marshal.GetFunctionPointerForDelegate(init.free_property_list_func)
            property_can_revert_func = Marshal.GetFunctionPointerForDelegate(init.property_can_revert_func)
            property_get_revert_func = Marshal.GetFunctionPointerForDelegate(init.property_get_revert_func)
            get_owner_func = Marshal.GetFunctionPointerForDelegate(init.get_owner_func)
            get_property_state_func = Marshal.GetFunctionPointerForDelegate(init.get_property_state_func)
            get_method_list_func = Marshal.GetFunctionPointerForDelegate(init.get_method_list_func)
            free_method_list_func = Marshal.GetFunctionPointerForDelegate(init.free_method_list_func)
            get_property_type_func = Marshal.GetFunctionPointerForDelegate(init.get_property_type_func)
            has_method_func = Marshal.GetFunctionPointerForDelegate(init.has_method_func)
            call_func = Marshal.GetFunctionPointerForDelegate(init.call_func)
            notification_func = Marshal.GetFunctionPointerForDelegate(init.notification_func)
            to_string_func = Marshal.GetFunctionPointerForDelegate(init.to_string_func)
            refcount_incremented_func = Marshal.GetFunctionPointerForDelegate(init.refcount_incremented_func)
            refcount_decremented_func = Marshal.GetFunctionPointerForDelegate(init.refcount_decremented_func)
            get_script_func = Marshal.GetFunctionPointerForDelegate(init.get_script_func)
            is_placeholder_func = Marshal.GetFunctionPointerForDelegate(init.is_placeholder_func)
            set_fallback_func = Marshal.GetFunctionPointerForDelegate(init.set_fallback_func)
            get_fallback_func = Marshal.GetFunctionPointerForDelegate(init.get_fallback_func)
            get_language_func = Marshal.GetFunctionPointerForDelegate(init.get_language_func)
            free_func = Marshal.GetFunctionPointerForDelegate(init.free_func)
        }
type [<Struct>] GDExtensionCallError = {
    error: GDExtensionCallErrorType
    argument: int32_t
    expected: int32_t
}
type [<Struct>] GDExtensionInitialization = {
    mutable minimum_initialization_level: GDExtensionInitializationLevel
    mutable userdata: nativeint
    mutable initialize: nativeint
    mutable deinitialize: nativeint
}
type GDExtensionScriptInstanceInfo2_SafeInit = {
    set_func: GDExtensionScriptInstanceSet
    get_func: GDExtensionScriptInstanceGet
    get_property_list_func: GDExtensionScriptInstanceGetPropertyList
    free_property_list_func: GDExtensionScriptInstanceFreePropertyList
    get_class_category_func: GDExtensionScriptInstanceGetClassCategory
    property_can_revert_func: GDExtensionScriptInstancePropertyCanRevert
    property_get_revert_func: GDExtensionScriptInstancePropertyGetRevert
    get_owner_func: GDExtensionScriptInstanceGetOwner
    get_property_state_func: GDExtensionScriptInstanceGetPropertyState
    get_method_list_func: GDExtensionScriptInstanceGetMethodList
    free_method_list_func: GDExtensionScriptInstanceFreeMethodList
    get_property_type_func: GDExtensionScriptInstanceGetPropertyType
    validate_property_func: GDExtensionScriptInstanceValidateProperty
    has_method_func: GDExtensionScriptInstanceHasMethod
    call_func: GDExtensionScriptInstanceCall
    notification_func: GDExtensionScriptInstanceNotification2
    to_string_func: GDExtensionScriptInstanceToString
    refcount_incremented_func: GDExtensionScriptInstanceRefCountIncremented
    refcount_decremented_func: GDExtensionScriptInstanceRefCountDecremented
    get_script_func: GDExtensionScriptInstanceGetScript
    is_placeholder_func: GDExtensionScriptInstanceIsPlaceholder
    set_fallback_func: GDExtensionScriptInstanceSet
    get_fallback_func: GDExtensionScriptInstanceGet
    get_language_func: GDExtensionScriptInstanceGetLanguage
    free_func: GDExtensionScriptInstanceFree
}
type [<Struct>] GDExtensionScriptInstanceInfo2 = {
    set_func: nativeint (* GDExtensionScriptInstanceSet: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> GDExtensionBool *)
    get_func: nativeint (* GDExtensionScriptInstanceGet: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    get_property_list_func: nativeint (* GDExtensionScriptInstanceGetPropertyList: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<uint32_t> -> nativeptr<GDExtensionPropertyInfo> *)
    free_property_list_func: nativeint (* GDExtensionScriptInstanceFreePropertyList: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionPropertyInfo> -> unit *)
    get_class_category_func: nativeint (* GDExtensionScriptInstanceGetClassCategory: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionPropertyInfo> -> GDExtensionBool *)
    property_can_revert_func: nativeint (* GDExtensionScriptInstancePropertyCanRevert: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr -> GDExtensionBool *)
    property_get_revert_func: nativeint (* GDExtensionScriptInstancePropertyGetRevert: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    get_owner_func: nativeint (* GDExtensionScriptInstanceGetOwner: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionObjectPtr *)
    get_property_state_func: nativeint (* GDExtensionScriptInstanceGetPropertyState: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionScriptInstancePropertyStateAdd * nativeint -> unit *)
    get_method_list_func: nativeint (* GDExtensionScriptInstanceGetMethodList: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<uint32_t> -> nativeptr<GDExtensionMethodInfo> *)
    free_method_list_func: nativeint (* GDExtensionScriptInstanceFreeMethodList: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionMethodInfo> -> unit *)
    get_property_type_func: nativeint (* GDExtensionScriptInstanceGetPropertyType: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionBool> -> GDExtensionVariantType *)
    validate_property_func: nativeint (* GDExtensionScriptInstanceValidateProperty: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionPropertyInfo> -> GDExtensionBool *)
    has_method_func: nativeint (* GDExtensionScriptInstanceHasMethod: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr -> GDExtensionBool *)
    call_func: nativeint (* GDExtensionScriptInstanceCall: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionVariantPtr * nativeptr<GDExtensionCallError> -> unit *)
    notification_func: nativeint (* GDExtensionScriptInstanceNotification2: delegate of GDExtensionScriptInstanceDataPtr * int32_t * GDExtensionBool -> unit *)
    to_string_func: nativeint (* GDExtensionScriptInstanceToString: delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionBool> * GDExtensionStringPtr -> unit *)
    refcount_incremented_func: nativeint (* GDExtensionScriptInstanceRefCountIncremented: delegate of GDExtensionScriptInstanceDataPtr -> unit *)
    refcount_decremented_func: nativeint (* GDExtensionScriptInstanceRefCountDecremented: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionBool *)
    get_script_func: nativeint (* GDExtensionScriptInstanceGetScript: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionObjectPtr *)
    is_placeholder_func: nativeint (* GDExtensionScriptInstanceIsPlaceholder: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionBool *)
    set_fallback_func: nativeint (* GDExtensionScriptInstanceSet: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> GDExtensionBool *)
    get_fallback_func: nativeint (* GDExtensionScriptInstanceGet: delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool *)
    get_language_func: nativeint (* GDExtensionScriptInstanceGetLanguage: delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionScriptLanguagePtr *)
    free_func: nativeint (* GDExtensionScriptInstanceFree: delegate of GDExtensionScriptInstanceDataPtr -> unit *)
} with
    static member Init (init: GDExtensionScriptInstanceInfo2_SafeInit) : GDExtensionScriptInstanceInfo2 =
        {
            set_func = Marshal.GetFunctionPointerForDelegate(init.set_func)
            get_func = Marshal.GetFunctionPointerForDelegate(init.get_func)
            get_property_list_func = Marshal.GetFunctionPointerForDelegate(init.get_property_list_func)
            free_property_list_func = Marshal.GetFunctionPointerForDelegate(init.free_property_list_func)
            get_class_category_func = Marshal.GetFunctionPointerForDelegate(init.get_class_category_func)
            property_can_revert_func = Marshal.GetFunctionPointerForDelegate(init.property_can_revert_func)
            property_get_revert_func = Marshal.GetFunctionPointerForDelegate(init.property_get_revert_func)
            get_owner_func = Marshal.GetFunctionPointerForDelegate(init.get_owner_func)
            get_property_state_func = Marshal.GetFunctionPointerForDelegate(init.get_property_state_func)
            get_method_list_func = Marshal.GetFunctionPointerForDelegate(init.get_method_list_func)
            free_method_list_func = Marshal.GetFunctionPointerForDelegate(init.free_method_list_func)
            get_property_type_func = Marshal.GetFunctionPointerForDelegate(init.get_property_type_func)
            validate_property_func = Marshal.GetFunctionPointerForDelegate(init.validate_property_func)
            has_method_func = Marshal.GetFunctionPointerForDelegate(init.has_method_func)
            call_func = Marshal.GetFunctionPointerForDelegate(init.call_func)
            notification_func = Marshal.GetFunctionPointerForDelegate(init.notification_func)
            to_string_func = Marshal.GetFunctionPointerForDelegate(init.to_string_func)
            refcount_incremented_func = Marshal.GetFunctionPointerForDelegate(init.refcount_incremented_func)
            refcount_decremented_func = Marshal.GetFunctionPointerForDelegate(init.refcount_decremented_func)
            get_script_func = Marshal.GetFunctionPointerForDelegate(init.get_script_func)
            is_placeholder_func = Marshal.GetFunctionPointerForDelegate(init.is_placeholder_func)
            set_fallback_func = Marshal.GetFunctionPointerForDelegate(init.set_fallback_func)
            get_fallback_func = Marshal.GetFunctionPointerForDelegate(init.get_fallback_func)
            get_language_func = Marshal.GetFunctionPointerForDelegate(init.get_language_func)
            free_func = Marshal.GetFunctionPointerForDelegate(init.free_func)
        }
type [<Struct>] GDExtensionGodotVersion = {
    major: uint32_t
    minor: uint32_t
    patch: uint32_t
    string: nativeptr<char>
}
type GDExtensionInterfaceStringOperatorIndex = delegate of GDExtensionStringPtr * GDExtensionInt -> nativeptr<char32_t>
type GDExtensionInterfaceStringToUtf8Chars = delegate of GDExtensionConstStringPtr * nativeptr<char> * GDExtensionInt -> GDExtensionInt
type GDExtensionInterfaceStringToUtf16Chars = delegate of GDExtensionConstStringPtr * nativeptr<char16_t> * GDExtensionInt -> GDExtensionInt
type GDExtensionInterfaceFileAccessStoreBuffer = delegate of GDExtensionObjectPtr * nativeptr<uint8_t> * uint64_t -> unit
type GDExtensionInterfaceXmlParserOpenBuffer = delegate of GDExtensionObjectPtr * nativeptr<uint8_t> * size_t -> GDExtensionInt
type GDExtensionInterfaceStringNameNewWithUtf8CharsAndLen = delegate of GDExtensionUninitializedStringNamePtr * nativeptr<char> * GDExtensionInt -> unit
type GDExtensionInterfaceStringNameNewWithUtf8Chars = delegate of GDExtensionUninitializedStringNamePtr * nativeptr<char> -> unit
type GDExtensionInterfaceStringNameNewWithLatin1Chars = delegate of GDExtensionUninitializedStringNamePtr * nativeptr<char> * GDExtensionBool -> unit
type GDExtensionInterfaceStringResize = delegate of GDExtensionStringPtr * GDExtensionInt -> GDExtensionInt
type GDExtensionInterfaceStringOperatorPlusEqC32str = delegate of GDExtensionStringPtr * nativeptr<char32_t> -> unit
type GDExtensionInterfaceStringOperatorPlusEqWcstr = delegate of GDExtensionStringPtr * nativeptr<wchar_t> -> unit
type GDExtensionInterfaceStringOperatorPlusEqCstr = delegate of GDExtensionStringPtr * nativeptr<char> -> unit
type GDExtensionInterfaceGetLibraryPath = delegate of GDExtensionClassLibraryPtr * GDExtensionUninitializedStringPtr -> unit
type GDExtensionInterfaceStringOperatorPlusEqChar = delegate of GDExtensionStringPtr * char32_t -> unit
type GDExtensionInterfaceStringToUtf32Chars = delegate of GDExtensionConstStringPtr * nativeptr<char32_t> * GDExtensionInt -> GDExtensionInt
type GDExtensionInterfaceStringToLatin1Chars = delegate of GDExtensionConstStringPtr * nativeptr<char> * GDExtensionInt -> GDExtensionInt
type GDExtensionInterfaceStringOperatorPlusEqString = delegate of GDExtensionStringPtr * GDExtensionConstStringPtr -> unit
type GDExtensionInterfaceClassdbUnregisterExtensionClass = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr -> unit
type GDExtensionInterfaceStringOperatorIndexConst = delegate of GDExtensionConstStringPtr * GDExtensionInt -> nativeptr<char32_t>
type GDExtensionInterfaceStringToWideChars = delegate of GDExtensionConstStringPtr * nativeptr<wchar_t> * GDExtensionInt -> GDExtensionInt
type GDExtensionInterfaceStringNewWithUtf32CharsAndLen = delegate of GDExtensionUninitializedStringPtr * nativeptr<char32_t> * GDExtensionInt -> unit
type GDExtensionInterfaceFileAccessGetBuffer = delegate of GDExtensionConstObjectPtr * nativeptr<uint8_t> * uint64_t -> uint64_t
type GDExtensionInterfaceVariantHasMember = delegate of GDExtensionVariantType * GDExtensionConstStringNamePtr -> GDExtensionBool
type GDExtensionInterfaceVariantHasKey = delegate of GDExtensionConstVariantPtr * GDExtensionConstVariantPtr * nativeptr<GDExtensionBool> -> GDExtensionBool
type GDExtensionInterfaceVariantGetTypeName = delegate of GDExtensionVariantType * GDExtensionUninitializedStringPtr -> unit
type GDExtensionInterfaceVariantCanConvert = delegate of GDExtensionVariantType * GDExtensionVariantType -> GDExtensionBool
type GDExtensionInterfaceVariantCanConvertStrict = delegate of GDExtensionVariantType * GDExtensionVariantType -> GDExtensionBool
type GDExtensionInterfaceGetVariantFromTypeConstructor = delegate of GDExtensionVariantType -> GDExtensionVariantFromTypeConstructorFunc
type GDExtensionInterfaceGetVariantToTypeConstructor = delegate of GDExtensionVariantType -> GDExtensionTypeFromVariantConstructorFunc
type GDExtensionInterfaceVariantGetPtrOperatorEvaluator = delegate of GDExtensionVariantOperator * GDExtensionVariantType * GDExtensionVariantType -> GDExtensionPtrOperatorEvaluator
type GDExtensionInterfaceVariantGetPtrBuiltinMethod = delegate of GDExtensionVariantType * GDExtensionConstStringNamePtr * GDExtensionInt -> GDExtensionPtrBuiltInMethod
type GDExtensionInterfaceVariantGetPtrConstructor = delegate of GDExtensionVariantType * int32_t -> GDExtensionPtrConstructor
type GDExtensionInterfaceVariantGetPtrDestructor = delegate of GDExtensionVariantType -> GDExtensionPtrDestructor
type GDExtensionInterfaceVariantConstruct = delegate of GDExtensionVariantType * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionConstVariantPtr> * int32_t * nativeptr<GDExtensionCallError> -> unit
type GDExtensionInterfaceVariantGetPtrSetter = delegate of GDExtensionVariantType * GDExtensionConstStringNamePtr -> GDExtensionPtrSetter
type GDExtensionInterfaceVariantGetPtrGetter = delegate of GDExtensionVariantType * GDExtensionConstStringNamePtr -> GDExtensionPtrGetter
type GDExtensionInterfaceVariantGetPtrIndexedSetter = delegate of GDExtensionVariantType -> GDExtensionPtrIndexedSetter
type GDExtensionInterfaceVariantGetPtrIndexedGetter = delegate of GDExtensionVariantType -> GDExtensionPtrIndexedGetter
type GDExtensionInterfaceVariantGetPtrKeyedSetter = delegate of GDExtensionVariantType -> GDExtensionPtrKeyedSetter
type GDExtensionInterfaceVariantGetPtrKeyedGetter = delegate of GDExtensionVariantType -> GDExtensionPtrKeyedGetter
type GDExtensionInterfaceVariantGetPtrKeyedChecker = delegate of GDExtensionVariantType -> GDExtensionPtrKeyedChecker
type GDExtensionInterfaceVariantGetConstantValue = delegate of GDExtensionVariantType * GDExtensionConstStringNamePtr * GDExtensionUninitializedVariantPtr -> unit
type GDExtensionInterfaceVariantGetPtrUtilityFunction = delegate of GDExtensionConstStringNamePtr * GDExtensionInt -> GDExtensionPtrUtilityFunction
type GDExtensionInterfaceStringNewWithLatin1Chars = delegate of GDExtensionUninitializedStringPtr * nativeptr<char> -> unit
type GDExtensionInterfaceStringNewWithUtf8Chars = delegate of GDExtensionUninitializedStringPtr * nativeptr<char> -> unit
type GDExtensionInterfaceStringNewWithUtf16Chars = delegate of GDExtensionUninitializedStringPtr * nativeptr<char16_t> -> unit
type GDExtensionInterfaceStringNewWithUtf32Chars = delegate of GDExtensionUninitializedStringPtr * nativeptr<char32_t> -> unit
type GDExtensionInterfaceStringNewWithWideChars = delegate of GDExtensionUninitializedStringPtr * nativeptr<wchar_t> -> unit
type GDExtensionInterfaceStringNewWithLatin1CharsAndLen = delegate of GDExtensionUninitializedStringPtr * nativeptr<char> * GDExtensionInt -> unit
type GDExtensionInterfaceStringNewWithUtf8CharsAndLen = delegate of GDExtensionUninitializedStringPtr * nativeptr<char> * GDExtensionInt -> unit
type GDExtensionInterfaceStringNewWithUtf16CharsAndLen = delegate of GDExtensionUninitializedStringPtr * nativeptr<char16_t> * GDExtensionInt -> unit
type GDExtensionInterfaceStringNewWithWideCharsAndLen = delegate of GDExtensionUninitializedStringPtr * nativeptr<wchar_t> * GDExtensionInt -> unit
type GDExtensionInterfaceWorkerThreadPoolAddNativeGroupTask_Arg2 = delegate of nativeint * uint32_t -> unit
type GDExtensionInterfaceWorkerThreadPoolAddNativeGroupTask = delegate of GDExtensionObjectPtr * GDExtensionInterfaceWorkerThreadPoolAddNativeGroupTask_Arg2 * nativeint * int * int * GDExtensionBool * GDExtensionConstStringPtr -> int64_t
type GDExtensionInterfacePackedFloat32ArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> nativeptr<single>
type GDExtensionInterfacePackedByteArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> nativeptr<uint8_t>
type GDExtensionInterfaceObjectFreeInstanceBinding = delegate of GDExtensionObjectPtr * nativeint -> unit
type GDExtensionInterfaceObjectSetInstance = delegate of GDExtensionObjectPtr * GDExtensionConstStringNamePtr * GDExtensionClassInstancePtr -> unit
type GDExtensionInterfaceObjectGetClassName = delegate of GDExtensionConstObjectPtr * GDExtensionClassLibraryPtr * GDExtensionUninitializedStringNamePtr -> GDExtensionBool
type GDExtensionInterfaceObjectCastTo = delegate of GDExtensionConstObjectPtr * nativeint -> GDExtensionObjectPtr
type GDExtensionInterfaceObjectGetInstanceFromId = delegate of GDObjectInstanceID -> GDExtensionObjectPtr
type GDExtensionInterfaceObjectGetInstanceId = delegate of GDExtensionConstObjectPtr -> GDObjectInstanceID
type GDExtensionInterfaceRefGetObject = delegate of GDExtensionConstRefPtr -> GDExtensionObjectPtr
type GDExtensionInterfaceVariantHasMethod = delegate of GDExtensionConstVariantPtr * GDExtensionConstStringNamePtr -> GDExtensionBool
type GDExtensionInterfaceRefSetObject = delegate of GDExtensionRefPtr * GDExtensionObjectPtr -> unit
type GDExtensionInterfaceScriptInstanceCreate = delegate of nativeptr<GDExtensionScriptInstanceInfo> * GDExtensionScriptInstanceDataPtr -> GDExtensionScriptInstancePtr
type GDExtensionInterfaceScriptInstanceCreate2 = delegate of nativeptr<GDExtensionScriptInstanceInfo2> * GDExtensionScriptInstanceDataPtr -> GDExtensionScriptInstancePtr
type GDExtensionInterfacePlaceHolderScriptInstanceCreate = delegate of GDExtensionObjectPtr * GDExtensionObjectPtr * GDExtensionObjectPtr -> GDExtensionScriptInstancePtr
type GDExtensionInterfaceObjectSetInstanceBinding = delegate of GDExtensionObjectPtr * nativeint * nativeint * nativeptr<GDExtensionInstanceBindingCallbacks> -> unit
type GDExtensionInterfacePlaceHolderScriptInstanceUpdate = delegate of GDExtensionScriptInstancePtr * GDExtensionConstTypePtr * GDExtensionConstTypePtr -> unit
type GDExtensionInterfaceCallableCustomCreate = delegate of GDExtensionUninitializedTypePtr * nativeptr<GDExtensionCallableCustomInfo> -> unit
type GDExtensionInterfaceCallableCustomGetUserData = delegate of GDExtensionConstTypePtr * nativeint -> nativeint
type GDExtensionInterfaceClassdbConstructObject = delegate of GDExtensionConstStringNamePtr -> GDExtensionObjectPtr
type GDExtensionInterfaceClassdbGetMethodBind = delegate of GDExtensionConstStringNamePtr * GDExtensionConstStringNamePtr * GDExtensionInt -> GDExtensionMethodBindPtr
type GDExtensionInterfaceClassdbGetClassTag = delegate of GDExtensionConstStringNamePtr -> nativeint
type GDExtensionInterfaceClassdbRegisterExtensionClass = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionClassCreationInfo> -> unit
type GDExtensionInterfaceClassdbRegisterExtensionClass2 = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionClassCreationInfo2> -> unit
type GDExtensionInterfaceClassdbRegisterExtensionClassMethod = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionClassMethodInfo> -> unit
type GDExtensionInterfaceClassdbRegisterExtensionClassIntegerConstant = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * GDExtensionConstStringNamePtr * GDExtensionConstStringNamePtr * GDExtensionInt * GDExtensionBool -> unit
type GDExtensionInterfaceClassdbRegisterExtensionClassProperty = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionPropertyInfo> * GDExtensionConstStringNamePtr * GDExtensionConstStringNamePtr -> unit
type GDExtensionInterfaceClassdbRegisterExtensionClassPropertyIndexed = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionPropertyInfo> * GDExtensionConstStringNamePtr * GDExtensionConstStringNamePtr * GDExtensionInt -> unit
type GDExtensionInterfaceClassdbRegisterExtensionClassPropertyGroup = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * GDExtensionConstStringPtr * GDExtensionConstStringPtr -> unit
type GDExtensionInterfaceObjectGetScriptInstance = delegate of GDExtensionConstObjectPtr * GDExtensionObjectPtr -> GDExtensionScriptInstanceDataPtr
type GDExtensionInterfaceWorkerThreadPoolAddNativeTask_Arg2 = delegate of nativeint -> unit
type GDExtensionInterfaceWorkerThreadPoolAddNativeTask = delegate of GDExtensionObjectPtr * GDExtensionInterfaceWorkerThreadPoolAddNativeTask_Arg2 * nativeint * GDExtensionBool * GDExtensionConstStringPtr -> int64_t
type GDExtensionInterfaceObjectGetInstanceBinding = delegate of GDExtensionObjectPtr * nativeint * nativeptr<GDExtensionInstanceBindingCallbacks> -> nativeint
type GDExtensionInterfaceObjectDestroy = delegate of GDExtensionObjectPtr -> unit
type GDExtensionInterfacePackedByteArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> nativeptr<uint8_t>
type GDExtensionInterfacePackedColorArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> GDExtensionTypePtr
type GDExtensionInterfacePackedColorArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> GDExtensionTypePtr
type GDExtensionInterfacePackedFloat32ArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> nativeptr<single>
type GDExtensionInterfacePackedFloat64ArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> nativeptr<double>
type GDExtensionInterfaceClassdbRegisterExtensionClassSignal = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionPropertyInfo> * GDExtensionInt -> unit
type GDExtensionInterfaceClassdbRegisterExtensionClassPropertySubgroup = delegate of GDExtensionClassLibraryPtr * GDExtensionConstStringNamePtr * GDExtensionConstStringPtr * GDExtensionConstStringPtr -> unit
type GDExtensionInterfacePackedFloat64ArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> nativeptr<double>
type GDExtensionInterfacePackedInt32ArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> nativeptr<int32_t>
type GDExtensionInterfacePackedInt32ArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> nativeptr<int32_t>
type GDExtensionInterfacePackedInt64ArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> nativeptr<int64_t>
type GDExtensionInterfacePackedInt64ArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> nativeptr<int64_t>
type GDExtensionInterfaceGlobalGetSingleton = delegate of GDExtensionConstStringNamePtr -> GDExtensionObjectPtr
type GDExtensionInterfacePackedStringArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> GDExtensionStringPtr
type GDExtensionInterfacePackedVector2ArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> GDExtensionTypePtr
type GDExtensionInterfacePackedVector2ArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> GDExtensionTypePtr
type GDExtensionInterfacePackedVector3ArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> GDExtensionTypePtr
type GDExtensionInterfacePackedVector3ArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> GDExtensionTypePtr
type GDExtensionInterfaceArrayOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionInt -> GDExtensionVariantPtr
type GDExtensionInterfaceArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> GDExtensionVariantPtr
type GDExtensionInterfaceArrayRef = delegate of GDExtensionTypePtr * GDExtensionConstTypePtr -> unit
type GDExtensionInterfaceArraySetTyped = delegate of GDExtensionTypePtr * GDExtensionVariantType * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> unit
type GDExtensionInterfaceDictionaryOperatorIndex = delegate of GDExtensionTypePtr * GDExtensionConstVariantPtr -> GDExtensionVariantPtr
type GDExtensionInterfaceDictionaryOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionConstVariantPtr -> GDExtensionVariantPtr
type GDExtensionInterfaceObjectMethodBindCall = delegate of GDExtensionMethodBindPtr * GDExtensionObjectPtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionCallError> -> unit
type GDExtensionInterfaceObjectMethodBindPtrcall = delegate of GDExtensionMethodBindPtr * GDExtensionObjectPtr * nativeptr<GDExtensionConstTypePtr> * GDExtensionTypePtr -> unit
type GDExtensionInterfacePackedStringArrayOperatorIndexConst = delegate of GDExtensionConstTypePtr * GDExtensionInt -> GDExtensionStringPtr
type GDExtensionInterfaceVariantGetType = delegate of GDExtensionConstVariantPtr -> GDExtensionVariantType
type GDExtensionScriptInstanceNotification2 = delegate of GDExtensionScriptInstanceDataPtr * int32_t * GDExtensionBool -> unit
type GDExtensionInterfaceVariantDuplicate = delegate of GDExtensionConstVariantPtr * GDExtensionVariantPtr * GDExtensionBool -> unit
type GDExtensionClassToString = delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionBool> * GDExtensionStringPtr -> unit
type GDExtensionClassReference = delegate of GDExtensionClassInstancePtr -> unit
type GDExtensionClassUnreference = delegate of GDExtensionClassInstancePtr -> unit
type GDExtensionClassCallVirtual = delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionConstTypePtr> * GDExtensionTypePtr -> unit
type GDExtensionClassCreateInstance = delegate of nativeint -> GDExtensionObjectPtr
type GDExtensionClassFreeInstance = delegate of nativeint * GDExtensionClassInstancePtr -> unit
type GDExtensionClassRecreateInstance = delegate of nativeint * GDExtensionObjectPtr -> GDExtensionClassInstancePtr
type GDExtensionClassGetVirtual = delegate of nativeint * GDExtensionConstStringNamePtr -> GDExtensionClassCallVirtual
type GDExtensionClassGetVirtualCallData = delegate of nativeint * GDExtensionConstStringNamePtr -> nativeint
type GDExtensionClassCallVirtualWithData = delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * nativeint * nativeptr<GDExtensionConstTypePtr> * GDExtensionTypePtr -> unit
type GDExtensionClassMethodCall = delegate of nativeint * GDExtensionClassInstancePtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionVariantPtr * nativeptr<GDExtensionCallError> -> unit
type GDExtensionClassNotification2 = delegate of GDExtensionClassInstancePtr * int32_t * GDExtensionBool -> unit
type GDExtensionClassMethodValidatedCall = delegate of nativeint * GDExtensionClassInstancePtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionVariantPtr -> unit
type GDExtensionCallableCustomCall = delegate of nativeint * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionVariantPtr * nativeptr<GDExtensionCallError> -> unit
type GDExtensionCallableCustomIsValid = delegate of nativeint -> GDExtensionBool
type GDExtensionCallableCustomFree = delegate of nativeint -> unit
type GDExtensionCallableCustomHash = delegate of nativeint -> uint32_t
type GDExtensionCallableCustomEqual = delegate of nativeint * nativeint -> GDExtensionBool
type GDExtensionCallableCustomLessThan = delegate of nativeint * nativeint -> GDExtensionBool
type GDExtensionCallableCustomToString = delegate of nativeint * nativeptr<GDExtensionBool> * GDExtensionStringPtr -> unit
type GDExtensionScriptInstanceSet = delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> GDExtensionBool
type GDExtensionScriptInstanceGet = delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool
type GDExtensionScriptInstanceGetPropertyList = delegate of GDExtensionScriptInstanceDataPtr * nativeptr<uint32_t> -> nativeptr<GDExtensionPropertyInfo>
type GDExtensionInterfaceVariantStringify = delegate of GDExtensionConstVariantPtr * GDExtensionStringPtr -> unit
type GDExtensionClassMethodPtrCall = delegate of nativeint * GDExtensionClassInstancePtr * nativeptr<GDExtensionConstTypePtr> * GDExtensionTypePtr -> unit
type GDExtensionScriptInstanceGetClassCategory = delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionPropertyInfo> -> GDExtensionBool
type GDExtensionClassNotification = delegate of GDExtensionClassInstancePtr * int32_t -> unit
type GDExtensionClassPropertyGetRevert = delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool
type GDExtensionVariantFromTypeConstructorFunc = delegate of GDExtensionUninitializedVariantPtr * GDExtensionTypePtr -> unit
type GDExtensionTypeFromVariantConstructorFunc = delegate of GDExtensionUninitializedTypePtr * GDExtensionVariantPtr -> unit
type GDExtensionPtrOperatorEvaluator = delegate of GDExtensionConstTypePtr * GDExtensionConstTypePtr * GDExtensionTypePtr -> unit
type GDExtensionPtrBuiltInMethod = delegate of GDExtensionTypePtr * nativeptr<GDExtensionConstTypePtr> * GDExtensionTypePtr * int -> unit
type GDExtensionPtrConstructor = delegate of GDExtensionUninitializedTypePtr * nativeptr<GDExtensionConstTypePtr> -> unit
type GDExtensionPtrDestructor = delegate of GDExtensionTypePtr -> unit
type GDExtensionPtrSetter = delegate of GDExtensionTypePtr * GDExtensionConstTypePtr -> unit
type GDExtensionPtrGetter = delegate of GDExtensionConstTypePtr * GDExtensionTypePtr -> unit
type GDExtensionPtrIndexedSetter = delegate of GDExtensionTypePtr * GDExtensionInt * GDExtensionConstTypePtr -> unit
type GDExtensionPtrIndexedGetter = delegate of GDExtensionConstTypePtr * GDExtensionInt * GDExtensionTypePtr -> unit
type GDExtensionPtrKeyedSetter = delegate of GDExtensionTypePtr * GDExtensionConstTypePtr * GDExtensionConstTypePtr -> unit
type GDExtensionClassValidateProperty = delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionPropertyInfo> -> GDExtensionBool
type GDExtensionPtrKeyedGetter = delegate of GDExtensionConstTypePtr * GDExtensionConstTypePtr * GDExtensionTypePtr -> unit
type GDExtensionPtrUtilityFunction = delegate of GDExtensionTypePtr * nativeptr<GDExtensionConstTypePtr> * int -> unit
type GDExtensionClassConstructor = delegate of unit -> GDExtensionObjectPtr
type GDExtensionInstanceBindingCreateCallback = delegate of nativeint * nativeint -> nativeint
type GDExtensionInstanceBindingFreeCallback = delegate of nativeint * nativeint * nativeint -> unit
type GDExtensionInstanceBindingReferenceCallback = delegate of nativeint * nativeint * GDExtensionBool -> GDExtensionBool
type GDExtensionClassSet = delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr -> GDExtensionBool
type GDExtensionClassGet = delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool
type GDExtensionClassGetRID = delegate of GDExtensionClassInstancePtr -> uint64_t
type GDExtensionClassGetPropertyList = delegate of GDExtensionClassInstancePtr * nativeptr<uint32_t> -> nativeptr<GDExtensionPropertyInfo>
type GDExtensionClassFreePropertyList = delegate of GDExtensionClassInstancePtr * nativeptr<GDExtensionPropertyInfo> -> unit
type GDExtensionClassPropertyCanRevert = delegate of GDExtensionClassInstancePtr * GDExtensionConstStringNamePtr -> GDExtensionBool
type GDExtensionPtrKeyedChecker = delegate of GDExtensionConstVariantPtr * GDExtensionConstVariantPtr -> uint32_t
type GDExtensionScriptInstanceGetPropertyType = delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionBool> -> GDExtensionVariantType
type GDExtensionScriptInstanceFreePropertyList = delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionPropertyInfo> -> unit
type GDExtensionScriptInstancePropertyCanRevert = delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr -> GDExtensionBool
type GDExtensionScriptInstanceValidateProperty = delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionPropertyInfo> -> GDExtensionBool
type GDExtensionInterfacePrintScriptErrorWithMessage = delegate of nativeptr<char> * nativeptr<char> * nativeptr<char> * nativeptr<char> * int32_t * GDExtensionBool -> unit
type GDExtensionInterfaceGetNativeStructSize = delegate of GDExtensionConstStringNamePtr -> uint64_t
type GDExtensionInterfaceVariantNewCopy = delegate of GDExtensionUninitializedVariantPtr * GDExtensionConstVariantPtr -> unit
type GDExtensionInterfaceVariantNewNil = delegate of GDExtensionUninitializedVariantPtr -> unit
type GDExtensionInterfaceVariantDestroy = delegate of GDExtensionVariantPtr -> unit
type GDExtensionInterfaceVariantCall = delegate of GDExtensionVariantPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionCallError> -> unit
type GDExtensionInterfaceVariantCallStatic = delegate of GDExtensionVariantType * GDExtensionConstStringNamePtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionCallError> -> unit
type GDExtensionInterfaceVariantEvaluate = delegate of GDExtensionVariantOperator * GDExtensionConstVariantPtr * GDExtensionConstVariantPtr * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfaceVariantSet = delegate of GDExtensionVariantPtr * GDExtensionConstVariantPtr * GDExtensionConstVariantPtr * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfaceVariantSetNamed = delegate of GDExtensionVariantPtr * GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfacePrintWarningWithMessage = delegate of nativeptr<char> * nativeptr<char> * nativeptr<char> * nativeptr<char> * int32_t * GDExtensionBool -> unit
type GDExtensionInterfaceVariantSetKeyed = delegate of GDExtensionVariantPtr * GDExtensionConstVariantPtr * GDExtensionConstVariantPtr * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfaceVariantGet = delegate of GDExtensionConstVariantPtr * GDExtensionConstVariantPtr * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfaceVariantGetNamed = delegate of GDExtensionConstVariantPtr * GDExtensionConstStringNamePtr * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfaceVariantGetKeyed = delegate of GDExtensionConstVariantPtr * GDExtensionConstVariantPtr * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfaceVariantGetIndexed = delegate of GDExtensionConstVariantPtr * GDExtensionInt * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionBool> * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfaceVariantIterInit = delegate of GDExtensionConstVariantPtr * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionBool> -> GDExtensionBool
type GDExtensionInterfaceVariantIterNext = delegate of GDExtensionConstVariantPtr * GDExtensionVariantPtr * nativeptr<GDExtensionBool> -> GDExtensionBool
type GDExtensionInterfaceVariantIterGet = delegate of GDExtensionConstVariantPtr * GDExtensionVariantPtr * GDExtensionUninitializedVariantPtr * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfaceVariantHash = delegate of GDExtensionConstVariantPtr -> GDExtensionInt
type GDExtensionInterfaceVariantRecursiveHash = delegate of GDExtensionConstVariantPtr * GDExtensionInt -> GDExtensionInt
type GDExtensionInterfaceVariantHashCompare = delegate of GDExtensionConstVariantPtr * GDExtensionConstVariantPtr -> GDExtensionBool
type GDExtensionInterfaceVariantBooleanize = delegate of GDExtensionConstVariantPtr -> GDExtensionBool
type GDExtensionInterfaceVariantSetIndexed = delegate of GDExtensionVariantPtr * GDExtensionInt * GDExtensionConstVariantPtr * nativeptr<GDExtensionBool> * nativeptr<GDExtensionBool> -> unit
type GDExtensionInterfacePrintWarning = delegate of nativeptr<char> * nativeptr<char> * nativeptr<char> * int32_t * GDExtensionBool -> unit
type GDExtensionInterfacePrintScriptError = delegate of nativeptr<char> * nativeptr<char> * nativeptr<char> * int32_t * GDExtensionBool -> unit
type GDExtensionInterfacePrintError = delegate of nativeptr<char> * nativeptr<char> * nativeptr<char> * int32_t * GDExtensionBool -> unit
type GDExtensionScriptInstancePropertyGetRevert = delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * GDExtensionVariantPtr -> GDExtensionBool
type GDExtensionScriptInstanceGetOwner = delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionObjectPtr
type GDExtensionScriptInstancePropertyStateAdd = delegate of GDExtensionConstStringNamePtr * GDExtensionConstVariantPtr * nativeint -> unit
type GDExtensionScriptInstanceGetPropertyState = delegate of GDExtensionScriptInstanceDataPtr * GDExtensionScriptInstancePropertyStateAdd * nativeint -> unit
type GDExtensionScriptInstanceGetMethodList = delegate of GDExtensionScriptInstanceDataPtr * nativeptr<uint32_t> -> nativeptr<GDExtensionMethodInfo>
type GDExtensionScriptInstanceFreeMethodList = delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionMethodInfo> -> unit
type GDExtensionScriptInstanceHasMethod = delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr -> GDExtensionBool
type GDExtensionScriptInstanceCall = delegate of GDExtensionScriptInstanceDataPtr * GDExtensionConstStringNamePtr * nativeptr<GDExtensionConstVariantPtr> * GDExtensionInt * GDExtensionVariantPtr * nativeptr<GDExtensionCallError> -> unit
type GDExtensionScriptInstanceNotification = delegate of GDExtensionScriptInstanceDataPtr * int32_t -> unit
type GDExtensionInterfacePrintErrorWithMessage = delegate of nativeptr<char> * nativeptr<char> * nativeptr<char> * nativeptr<char> * int32_t * GDExtensionBool -> unit
type GDExtensionScriptInstanceToString = delegate of GDExtensionScriptInstanceDataPtr * nativeptr<GDExtensionBool> * GDExtensionStringPtr -> unit
type GDExtensionScriptInstanceRefCountIncremented = delegate of GDExtensionScriptInstanceDataPtr -> unit
type GDExtensionInterfaceEditorAddPlugin = delegate of GDExtensionConstStringNamePtr -> unit
type GDExtensionScriptInstanceGetScript = delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionObjectPtr
type GDExtensionInterfaceMemFree = delegate of nativeint -> unit
type GDExtensionInterfaceMemRealloc = delegate of nativeint * size_t -> nativeint
type GDExtensionScriptInstanceRefCountDecremented = delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionBool
type GDExtensionInterfaceGetGodotVersion = delegate of nativeptr<GDExtensionGodotVersion> -> unit
type GDExtensionInitializationFunction = delegate of GDExtensionInterfaceGetProcAddress * GDExtensionClassLibraryPtr * nativeptr<GDExtensionInitialization> -> GDExtensionBool
type GDExtensionInterfaceMemAlloc = delegate of size_t -> nativeint
type GDExtensionInterfaceFunctionPtr = delegate of unit -> unit
type GDExtensionScriptInstanceFree = delegate of GDExtensionScriptInstanceDataPtr -> unit
type GDExtensionScriptInstanceGetLanguage = delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionScriptLanguagePtr
type GDExtensionScriptInstanceIsPlaceholder = delegate of GDExtensionScriptInstanceDataPtr -> GDExtensionBool
type GDExtensionInterfaceGetProcAddress = delegate of nativeptr<char> -> nativeint // GDExtensionInterfaceFunctionPtr
type GDExtensionInterfaceEditorRemovePlugin = delegate of GDExtensionConstStringNamePtr -> unit
[<DllImport("gdextension")>]
extern void __report_gsfailure (uintptr_t _StackCookie)
[<DllImport("gdextension")>]
extern void __security_check_cookie (uintptr_t _StackCookie)
[<DllImport("gdextension")>]
extern void __security_init_cookie ()
[<DllImport("gdextension")>]
extern void __va_start (va_list * )
type [<Struct>] Variant = private {
    a: byte
    b: byte
    c: byte
    d: byte
    e: byte
    f: byte
    g: byte
    h: byte
    i: byte
    j: byte
    k: byte
    l: byte
    m: byte
    n: byte
    o: byte
    p: byte
    q: byte
    r: byte
    s: byte
    t: byte
    u: byte
    v: byte
    w: byte
    x: byte
}
type [<Struct>] GodotString = private {
    a: byte
    b: byte
    c: byte
    d: byte
    e: byte
    f: byte
    g: byte
    h: byte
}
let inline to_c_str (ptr: nativeptr<byte>) = ptr |> NativeInterop.NativePtr.toNativeInt |> NativeInterop.NativePtr.ofNativeInt<char>
let inline toNativeInt ptr = ptr |> NativeInterop.NativePtr.toNativeInt
let onInitializeLevel (userData: nativeint) (p_level: GDExtensionInitializationLevel) =
    printfn $"Init: %A{p_level}"
let onDeinitializeLevel (userData: nativeint) (p_level:GDExtensionInitializationLevel) =
    printfn $"Deinit: %A{p_level}"
type InitializeDelegate = delegate of nativeint * GDExtensionInitializationLevel -> unit
let init (getProcAddress: GDExtensionInterfaceGetProcAddress) (p_library: GDExtensionClassLibraryPtr) (r_initialization: nativeptr<GDExtensionInitialization>) =
    let initialization_data = NativeInterop.NativePtr.toByRef r_initialization
    initialization_data.initialize <- Marshal.GetFunctionPointerForDelegate(InitializeDelegate onInitializeLevel)
    initialization_data.deinitialize <- Marshal.GetFunctionPointerForDelegate(InitializeDelegate onDeinitializeLevel)
    initialization_data.userdata <- nativeint 420
    printfn $"init: %A{initialization_data}"
    let getProc (name: string) =
        use str = fixed (UTF8.GetBytes name)
        Marshal.GetDelegateForFunctionPointer<'t>(getProcAddress.Invoke(to_c_str str))
    let string_name_new_with_latin1_chars: GDExtensionInterfaceStringNameNewWithLatin1Chars =
        getProc "string_name_new_with_latin1_chars"
    let variant_get_ptr_utility_function: GDExtensionInterfaceVariantGetPtrUtilityFunction =
        getProc "variant_get_ptr_utility_function"
    let string_new_with_utf8_chars: GDExtensionInterfaceStringNewWithUtf8Chars =
        getProc "string_new_with_utf8_chars"
    let get_variant_from_type_constructor: GDExtensionInterfaceGetVariantFromTypeConstructor  =
        getProc "get_variant_from_type_constructor"
        
    let mutable proc_name = Unchecked.defaultof<Variant>
    use str = fixed UTF8.GetBytes "print"
    string_name_new_with_latin1_chars.Invoke(toNativeInt &&proc_name, to_c_str str, 0uy)
    let log = variant_get_ptr_utility_function.Invoke(toNativeInt &&proc_name, 2648703342L)
    
    let mutable msg = Unchecked.defaultof<GodotString>
    use msgBytes = fixed UTF8.GetBytes "Hello to Godot from F#!"
    string_new_with_utf8_chars.Invoke(toNativeInt &&msg, to_c_str msgBytes)
    let ctor = get_variant_from_type_constructor.Invoke(GDExtensionVariantType.GDEXTENSION_VARIANT_TYPE_STRING)
    let mutable print_msg = Unchecked.defaultof<Variant>
    ctor.Invoke(toNativeInt &&print_msg, toNativeInt &&msg)
    use argsArray = fixed [| toNativeInt &&print_msg |]
    let mutable returnValue = Unchecked.defaultof<Variant>
    log.Invoke(toNativeInt &&returnValue, argsArray, 1)
    printfn $"%A{returnValue}"