using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[DefaultMember("symIndexId")]
	[Guid("CB787B2F-BD6C-4635-BA52-933126BD2DCD")]
	public interface IDiaSymbol
	{
		[DispId(0)]
		uint symIndexId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(1)]
		uint symTag
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(2)]
		string name
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(3)]
		IDiaSymbol lexicalParent
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(4)]
		IDiaSymbol classParent
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		/// <summary>Note that it is possible for a symbol to not have a type and
		/// thus the resulting value being a null reference. This doesn't prevent
		/// the symbol to have children that you can find using one of the
		/// <see cref="findChildren"/> method. Structures are examples of such
		/// symbols.</summary>
		[DispId(5)]
		IDiaSymbol type
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(6)]
		uint dataKind
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(7)]
		uint locationType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(8)]
		uint addressSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(9)]
		uint addressOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(10)]
		uint relativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(11)]
		ulong virtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(12)]
		uint registerId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(13)]
		int offset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(14)]
		ulong length
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(15)]
		uint slot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(16)]
		int volatileType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(17)]
		int constType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(18)]
		int unalignedType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(19)]
		uint access
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(20)]
		string libraryName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(21)]
		uint platform
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(22)]
		uint language
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(23)]
		int editAndContinueEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(24)]
		uint frontEndMajor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(25)]
		uint frontEndMinor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(26)]
		uint frontEndBuild
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(27)]
		uint backEndMajor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(28)]
		uint backEndMinor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(29)]
		uint backEndBuild
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(30)]
		string sourceFileName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(31)]
		string unused
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(32)]
		uint thunkOrdinal
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(33)]
		int thisAdjust
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(34)]
		uint virtualBaseOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(35)]
		int @virtual
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(36)]
		int intro
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(37)]
		int pure
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(38)]
		uint callingConvention
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(39)]
		object value
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
		}

		[DispId(40)]
		uint baseType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(41)]
		uint token
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(42)]
		uint timeStamp
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(43)]
		Guid guid
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(44)]
		string symbolsFileName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(46)]
		int reference
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(47)]
		uint count
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(49)]
		uint bitPosition
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(50)]
		IDiaSymbol arrayIndexType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(51)]
		int packed
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(52)]
		int constructor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(53)]
		int overloadedOperator
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(54)]
		int nested
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(55)]
		int hasNestedTypes
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(56)]
		int hasAssignmentOperator
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(57)]
		int hasCastOperator
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(58)]
		int scoped
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(59)]
		int virtualBaseClass
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(60)]
		int indirectVirtualBaseClass
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(61)]
		int virtualBasePointerOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(62)]
		IDiaSymbol virtualTableShape
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(64)]
		uint lexicalParentId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(65)]
		uint classParentId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(66)]
		uint typeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(67)]
		uint arrayIndexTypeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(68)]
		uint virtualTableShapeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(69)]
		int code
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(70)]
		int function
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(71)]
		int managed
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(72)]
		int msil
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(73)]
		uint virtualBaseDispIndex
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(74)]
		string undecoratedName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(75)]
		uint age
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(76)]
		uint signature
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(77)]
		int compilerGenerated
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(78)]
		int addressTaken
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(79)]
		uint rank
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(80)]
		IDiaSymbol lowerBound
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(81)]
		IDiaSymbol upperBound
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(82)]
		uint lowerBoundId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(83)]
		uint upperBoundId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void get_dataBytes(
			[In] uint cbData,
			[Out] out uint pcbData,
			[In, Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref byte[] pbData);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildren([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string? name, [In] uint compareFlags, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildrenEx([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildrenExByAddr([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [In] uint isect, [In] uint offset, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildrenExByVA([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [In] ulong va, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildrenExByRVA([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [In] uint rva, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[DispId(84)]
		uint targetSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(85)]
		uint targetOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(86)]
		uint targetRelativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(87)]
		ulong targetVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(88)]
		uint machineType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(89)]
		uint oemId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(90)]
		uint oemSymbolId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void get_types([In] uint cTypes, out uint pcTypes, [MarshalAs(UnmanagedType.Interface)] out IDiaSymbol pTypes);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void get_typeIds([In] uint cTypeIds, out uint pcTypeIds, out uint pdwTypeIds);

		[DispId(91)]
		IDiaSymbol objectPointerType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(92)]
		uint udtKind
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void get_undecoratedNameEx([In] uint undecorateOptions, [MarshalAs(UnmanagedType.BStr)] out string name);

		[DispId(93)]
		int noReturn
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(94)]
		int customCallingConvention
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(95)]
		int noInline
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(96)]
		int optimizedCodeDebugInfo
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(97)]
		int notReached
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(98)]
		int interruptReturn
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(99)]
		int farReturn
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(100)]
		int isStatic
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(101)]
		int hasDebugInfo
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(102)]
		int isLTCG
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(103)]
		int isDataAligned
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(104)]
		int hasSecurityChecks
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(105)]
		string compilerName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(106)]
		int hasAlloca
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(107)]
		int hasSetJump
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(108)]
		int hasLongJump
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(109)]
		int hasInlAsm
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(110)]
		int hasEH
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(111)]
		int hasSEH
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(112)]
		int hasEHa
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(113)]
		int isNaked
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(114)]
		int isAggregated
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(115)]
		int isSplitted
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(116)]
		IDiaSymbol container
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(117)]
		int inlSpec
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(118)]
		int noStackOrdering
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(119)]
		IDiaSymbol virtualBaseTableType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(120)]
		int hasManagedCode
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(121)]
		int isHotpatchable
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(122)]
		int isCVTCIL
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(123)]
		int isMSILNetmodule
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(124)]
		int isCTypes
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(125)]
		int isStripped
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(126)]
		uint frontEndQFE
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(127)]
		uint backEndQFE
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(128)]
		int wasInlined
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(129)]
		int strictGSCheck
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(130)]
		int isCxxReturnUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(131)]
		int isConstructorVirtualBase
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(132)]
		int RValueReference
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(133)]
		IDiaSymbol unmodifiedType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(134)]
		int framePointerPresent
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(135)]
		int isSafeBuffers
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(136)]
		int intrinsic
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(137)]
		int @sealed
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(138)]
		int hfaFloat
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(139)]
		int hfaDouble
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(140)]
		uint liveRangeStartAddressSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(141)]
		uint liveRangeStartAddressOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(142)]
		uint liveRangeStartRelativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(143)]
		uint countLiveRanges
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(144)]
		ulong liveRangeLength
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(145)]
		uint offsetInUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(146)]
		uint paramBasePointerRegisterId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(147)]
		uint localBasePointerRegisterId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(148)]
		int isLocationControlFlowDependent
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(149)]
		uint stride
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(150)]
		uint numberOfRows
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(151)]
		uint numberOfColumns
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(152)]
		int isMatrixRowMajor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void get_numericProperties([In] uint cnt, out uint pcnt, out uint pProperties);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void get_modifierValues([In] uint cnt, out uint pcnt, out ushort pModifiers);

		[DispId(153)]
		int isReturnValue
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(154)]
		int isOptimizedAway
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(155)]
		uint builtInKind
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(156)]
		uint registerType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(157)]
		uint baseDataSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(158)]
		uint baseDataOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(159)]
		uint textureSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(160)]
		uint samplerSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(161)]
		uint uavSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(162)]
		uint sizeInUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(163)]
		uint memorySpaceKind
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(164)]
		uint unmodifiedTypeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(165)]
		uint subTypeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(166)]
		IDiaSymbol subType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(167)]
		uint numberOfModifiers
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(168)]
		uint numberOfRegisterIndices
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(169)]
		int isHLSLData
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(170)]
		int isPointerToDataMember
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(171)]
		int isPointerToMemberFunction
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(172)]
		int isSingleInheritance
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(173)]
		int isMultipleInheritance
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(174)]
		int isVirtualInheritance
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(175)]
		int restrictedType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(176)]
		int isPointerBasedOnSymbolValue
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(177)]
		IDiaSymbol baseSymbol
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(178)]
		uint baseSymbolId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(179)]
		string objectFileName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(180)]
		int isAcceleratorGroupSharedLocal
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(181)]
		int isAcceleratorPointerTagLiveRange
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(182)]
		int isAcceleratorStubFunction
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(183)]
		uint numberOfAcceleratorPointerTags
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(184)]
		int isSdl
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(185)]
		int isWinRTPointer
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(186)]
		int isRefUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(187)]
		int isValueUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(188)]
		int isInterfaceUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineFramesByAddr([In] uint isect, [In] uint offset, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineFramesByRVA([In] uint rva, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineFramesByVA([In] ulong va, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLines([MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLinesByAddr([In] uint isect, [In] uint offset, [In] uint length, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLinesByRVA([In] uint rva, [In] uint length, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLinesByVA([In] ulong va, [In] uint length, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolsForAcceleratorPointerTag([In] uint tagValue, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolsByRVAForAcceleratorPointerTag([In] uint tagValue, [In] uint rva, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void get_acceleratorPointerTags([In] uint cnt, out uint pcnt, out uint pPointerTags);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getSrcLineOnTypeDefn([MarshalAs(UnmanagedType.Interface)] out IDiaLineNumber ppResult);

		[DispId(189)]
		int isPGO
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(190)]
		int hasValidPGOCounts
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(191)]
		int isOptimizedForSpeed
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(192)]
		uint PGOEntryCount
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(193)]
		uint PGOEdgeCount
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(194)]
		ulong PGODynamicInstructionCount
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(195)]
		uint staticSize
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(196)]
		uint finalLiveStaticSize
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(197)]
		string phaseName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(198)]
		int hasControlFlowCheck
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(199)]
		int constantExport
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(200)]
		int dataExport
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(201)]
		int privateExport
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(202)]
		int noNameExport
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(203)]
		int exportHasExplicitlyAssignedOrdinal
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(204)]
		int exportIsForwarder
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(205)]
		uint ordinal
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(206)]
		uint frameSize
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(207)]
		uint exceptionHandlerAddressSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(208)]
		uint exceptionHandlerAddressOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(209)]
		uint exceptionHandlerRelativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(210)]
		ulong exceptionHandlerVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInputAssemblyFile([MarshalAs(UnmanagedType.Interface)] out IDiaInputAssemblyFile ppResult);

		[DispId(211)]
		uint characteristics
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(212)]
		IDiaSymbol coffGroup
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(213)]
		uint bindID
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(214)]
		uint bindSpace
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(215)]
		uint bindSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
