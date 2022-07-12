using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[DefaultMember("symIndexId")]
	[Guid("64CE6CD5-7315-4328-86D6-10E303E010B4")]
	public interface IDiaSymbol7 : IDiaSymbol6
	{
		[DispId(0)]
		new uint symIndexId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(1)]
		new uint symTag
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(2)]
		new string name
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(3)]
		new IDiaSymbol lexicalParent
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(4)]
		new IDiaSymbol classParent
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(5)]
		new IDiaSymbol type
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(6)]
		new uint dataKind
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(7)]
		new uint locationType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(8)]
		new uint addressSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(9)]
		new uint addressOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(10)]
		new uint relativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(11)]
		new ulong virtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(12)]
		new uint registerId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(13)]
		new int offset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(14)]
		new ulong length
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(15)]
		new uint slot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(16)]
		new int volatileType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(17)]
		new int constType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(18)]
		new int unalignedType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(19)]
		new uint access
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(20)]
		new string libraryName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(21)]
		new uint platform
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(22)]
		new uint language
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(23)]
		new int editAndContinueEnabled
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(24)]
		new uint frontEndMajor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(25)]
		new uint frontEndMinor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(26)]
		new uint frontEndBuild
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(27)]
		new uint backEndMajor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(28)]
		new uint backEndMinor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(29)]
		new uint backEndBuild
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(30)]
		new string sourceFileName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(31)]
		new string unused
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(32)]
		new uint thunkOrdinal
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(33)]
		new int thisAdjust
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(34)]
		new uint virtualBaseOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(35)]
		new int @virtual
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(36)]
		new int intro
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(37)]
		new int pure
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(38)]
		new uint callingConvention
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(39)]
		new object value
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Struct)]
			get;
		}

		[DispId(40)]
		new uint baseType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(41)]
		new uint token
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(42)]
		new uint timeStamp
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(43)]
		new Guid guid
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(44)]
		new string symbolsFileName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(46)]
		new int reference
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(47)]
		new uint count
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(49)]
		new uint bitPosition
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(50)]
		new IDiaSymbol arrayIndexType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(51)]
		new int packed
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(52)]
		new int constructor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(53)]
		new int overloadedOperator
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(54)]
		new int nested
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(55)]
		new int hasNestedTypes
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(56)]
		new int hasAssignmentOperator
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(57)]
		new int hasCastOperator
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(58)]
		new int scoped
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(59)]
		new int virtualBaseClass
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(60)]
		new int indirectVirtualBaseClass
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(61)]
		new int virtualBasePointerOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(62)]
		new IDiaSymbol virtualTableShape
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(64)]
		new uint lexicalParentId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(65)]
		new uint classParentId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(66)]
		new uint typeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(67)]
		new uint arrayIndexTypeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(68)]
		new uint virtualTableShapeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(69)]
		new int code
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(70)]
		new int function
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(71)]
		new int managed
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(72)]
		new int msil
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(73)]
		new uint virtualBaseDispIndex
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(74)]
		new string undecoratedName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(75)]
		new uint age
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(76)]
		new uint signature
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(77)]
		new int compilerGenerated
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(78)]
		new int addressTaken
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(79)]
		new uint rank
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(80)]
		new IDiaSymbol lowerBound
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(81)]
		new IDiaSymbol upperBound
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(82)]
		new uint lowerBoundId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(83)]
		new uint upperBoundId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(84)]
		new uint targetSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(85)]
		new uint targetOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(86)]
		new uint targetRelativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(87)]
		new ulong targetVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(88)]
		new uint machineType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(89)]
		new uint oemId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(90)]
		new uint oemSymbolId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(91)]
		new IDiaSymbol objectPointerType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(92)]
		new uint udtKind
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(93)]
		new int noReturn
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(94)]
		new int customCallingConvention
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(95)]
		new int noInline
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(96)]
		new int optimizedCodeDebugInfo
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(97)]
		new int notReached
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(98)]
		new int interruptReturn
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(99)]
		new int farReturn
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(100)]
		new int isStatic
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(101)]
		new int hasDebugInfo
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(102)]
		new int isLTCG
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(103)]
		new int isDataAligned
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(104)]
		new int hasSecurityChecks
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(105)]
		new string compilerName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(106)]
		new int hasAlloca
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(107)]
		new int hasSetJump
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(108)]
		new int hasLongJump
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(109)]
		new int hasInlAsm
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(110)]
		new int hasEH
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(111)]
		new int hasSEH
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(112)]
		new int hasEHa
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(113)]
		new int isNaked
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(114)]
		new int isAggregated
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(115)]
		new int isSplitted
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(116)]
		new IDiaSymbol container
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(117)]
		new int inlSpec
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(118)]
		new int noStackOrdering
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(119)]
		new IDiaSymbol virtualBaseTableType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(120)]
		new int hasManagedCode
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(121)]
		new int isHotpatchable
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(122)]
		new int isCVTCIL
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(123)]
		new int isMSILNetmodule
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(124)]
		new int isCTypes
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(125)]
		new int isStripped
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(126)]
		new uint frontEndQFE
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(127)]
		new uint backEndQFE
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(128)]
		new int wasInlined
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(129)]
		new int strictGSCheck
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(130)]
		new int isCxxReturnUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(131)]
		new int isConstructorVirtualBase
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(132)]
		new int RValueReference
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(133)]
		new IDiaSymbol unmodifiedType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(134)]
		new int framePointerPresent
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(135)]
		new int isSafeBuffers
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(136)]
		new int intrinsic
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(137)]
		new int @sealed
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(138)]
		new int hfaFloat
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(139)]
		new int hfaDouble
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(140)]
		new uint liveRangeStartAddressSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(141)]
		new uint liveRangeStartAddressOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(142)]
		new uint liveRangeStartRelativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(143)]
		new uint countLiveRanges
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(144)]
		new ulong liveRangeLength
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(145)]
		new uint offsetInUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(146)]
		new uint paramBasePointerRegisterId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(147)]
		new uint localBasePointerRegisterId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(148)]
		new int isLocationControlFlowDependent
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(149)]
		new uint stride
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(150)]
		new uint numberOfRows
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(151)]
		new uint numberOfColumns
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(152)]
		new int isMatrixRowMajor
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(153)]
		new int isReturnValue
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(154)]
		new int isOptimizedAway
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(155)]
		new uint builtInKind
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(156)]
		new uint registerType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(157)]
		new uint baseDataSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(158)]
		new uint baseDataOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(159)]
		new uint textureSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(160)]
		new uint samplerSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(161)]
		new uint uavSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(162)]
		new uint sizeInUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(163)]
		new uint memorySpaceKind
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(164)]
		new uint unmodifiedTypeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(165)]
		new uint subTypeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(166)]
		new IDiaSymbol subType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(167)]
		new uint numberOfModifiers
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(168)]
		new uint numberOfRegisterIndices
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(169)]
		new int isHLSLData
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(170)]
		new int isPointerToDataMember
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(171)]
		new int isPointerToMemberFunction
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(172)]
		new int isSingleInheritance
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(173)]
		new int isMultipleInheritance
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(174)]
		new int isVirtualInheritance
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(175)]
		new int restrictedType
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(176)]
		new int isPointerBasedOnSymbolValue
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(177)]
		new IDiaSymbol baseSymbol
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(178)]
		new uint baseSymbolId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(179)]
		new string objectFileName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(180)]
		new int isAcceleratorGroupSharedLocal
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(181)]
		new int isAcceleratorPointerTagLiveRange
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(182)]
		new int isAcceleratorStubFunction
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(183)]
		new uint numberOfAcceleratorPointerTags
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(184)]
		new int isSdl
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(185)]
		new int isWinRTPointer
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(186)]
		new int isRefUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(187)]
		new int isValueUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(188)]
		new int isInterfaceUdt
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(189)]
		new int isPGO
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(190)]
		new int hasValidPGOCounts
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(191)]
		new int isOptimizedForSpeed
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(192)]
		new uint PGOEntryCount
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(193)]
		new uint PGOEdgeCount
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(194)]
		new ulong PGODynamicInstructionCount
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(195)]
		new uint staticSize
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(196)]
		new uint finalLiveStaticSize
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(197)]
		new string phaseName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(198)]
		new int hasControlFlowCheck
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(199)]
		new int constantExport
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(200)]
		new int dataExport
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(201)]
		new int privateExport
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(202)]
		new int noNameExport
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(203)]
		new int exportHasExplicitlyAssignedOrdinal
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(204)]
		new int exportIsForwarder
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(205)]
		new uint ordinal
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(206)]
		new uint frameSize
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(207)]
		new uint exceptionHandlerAddressSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(208)]
		new uint exceptionHandlerAddressOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(209)]
		new uint exceptionHandlerRelativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(210)]
		new ulong exceptionHandlerVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(211)]
		new uint characteristics
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(212)]
		new IDiaSymbol coffGroup
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(213)]
		new uint bindID
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(214)]
		new uint bindSpace
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(215)]
		new uint bindSlot
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(216)]
		new int isObjCClass
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(217)]
		new int isObjCCategory
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(218)]
		new int isObjCProtocol
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(219)]
		new IDiaSymbol inlinee
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(220)]
		new uint inlineeId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(221)]
		new int noexcept
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(222)]
		new int hasAbsoluteAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(223)]
		new int isStaticMemberFunc
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(224)]
		int isSignRet
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void get_dataBytes([In] uint cbData, out uint pcbData, out byte pbData);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findChildren([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findChildrenEx([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findChildrenExByAddr([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [In] uint isect, [In] uint offset, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findChildrenExByVA([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [In] ulong va, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findChildrenExByRVA([In] SymTagEnum symTag, [In][MarshalAs(UnmanagedType.LPWStr)] string name, [In] uint compareFlags, [In] uint rva, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void get_types([In] uint cTypes, out uint pcTypes, [MarshalAs(UnmanagedType.Interface)] out IDiaSymbol pTypes);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void get_typeIds([In] uint cTypeIds, out uint pcTypeIds, out uint pdwTypeIds);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void get_undecoratedNameEx([In] uint undecorateOptions, [MarshalAs(UnmanagedType.BStr)] out string name);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void get_numericProperties([In] uint cnt, out uint pcnt, out uint pProperties);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void get_modifierValues([In] uint cnt, out uint pcnt, out ushort pModifiers);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findInlineFramesByAddr([In] uint isect, [In] uint offset, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findInlineFramesByRVA([In] uint rva, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findInlineFramesByVA([In] ulong va, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findInlineeLines([MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findInlineeLinesByAddr([In] uint isect, [In] uint offset, [In] uint length, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findInlineeLinesByRVA([In] uint rva, [In] uint length, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findInlineeLinesByVA([In] ulong va, [In] uint length, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findSymbolsForAcceleratorPointerTag([In] uint tagValue, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findSymbolsByRVAForAcceleratorPointerTag([In] uint tagValue, [In] uint rva, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void get_acceleratorPointerTags([In] uint cnt, out uint pcnt, out uint pPointerTags);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void getSrcLineOnTypeDefn([MarshalAs(UnmanagedType.Interface)] out IDiaLineNumber ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void findInputAssemblyFile([MarshalAs(UnmanagedType.Interface)] out IDiaInputAssemblyFile ppResult);
	}
}
