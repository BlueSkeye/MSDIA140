using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("2F609EE1-D1C8-4E24-8288-3326BADCD211")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaSession
	{
		[DispId(1)]
		ulong loadAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[param: In]
			set;
		}

		[DispId(2)]
		IDiaSymbol globalScope
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getEnumTables(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumTables ppEnumTables);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getSymbolsByAddr(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbolsByAddr ppEnumbyAddr);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildren(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] SymTagEnum symTag,
			[In][MarshalAs(UnmanagedType.LPWStr)] string? name,
			[In] NameSearchOptions compareFlags,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildrenEx(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] SymTagEnum symTag,
			[In][MarshalAs(UnmanagedType.LPWStr)] string? name,
			[In] NameSearchOptions compareFlags,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildrenExByAddr(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] SymTagEnum symTag,
			[In][MarshalAs(UnmanagedType.LPWStr)] string? name,
			[In] NameSearchOptions compareFlags,
			[In] uint isect,
			[In] uint offset,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildrenExByVA(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] SymTagEnum symTag,
			[In][MarshalAs(UnmanagedType.LPWStr)] string? name,
			[In] NameSearchOptions compareFlags,
			[In] ulong va,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findChildrenExByRVA(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] SymTagEnum symTag,
			[In][MarshalAs(UnmanagedType.LPWStr)] string? name,
			[In] NameSearchOptions compareFlags,
			[In] uint rva,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolByAddr(
			[In] uint isect,
			[In] uint offset,
			[In] SymTagEnum symTag,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolByRVA(
			[In] uint rva,
			[In] SymTagEnum symTag,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolByVA(
			[In] ulong va,
			[In] SymTagEnum symTag,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolByToken(
			[In] uint token,
			[In] SymTagEnum symTag,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void symsAreEquiv(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol symbolA,
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol symbolB);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void symbolById([In] uint id,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolByRVAEx(
			[In] uint rva,
			[In] SymTagEnum symTag,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol,
			[Out]out int displacement);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolByVAEx(
			[In] ulong va,
			[In] SymTagEnum symTag,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol,
			[Out]out int displacement);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findFile(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol pCompiland,
			[In][MarshalAs(UnmanagedType.LPWStr)] string? name,
			[In] NameSearchOptions compareFlags,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSourceFiles ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findFileById(
			[In] uint uniqueId,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSourceFile ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findLines(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol compiland, 
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSourceFile file,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findLinesByAddr(
			[In] uint seg,
			[In] uint offset,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findLinesByRVA(
			[In] uint rva,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findLinesByVA(
			[In] ulong va,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findLinesByLinenum(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol compiland,
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSourceFile file,
			[In] uint linenum,
			[In] uint column,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInjectedSource(
			[In][MarshalAs(UnmanagedType.LPWStr)] string srcFile,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumInjectedSources ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getEnumDebugStreams(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumDebugStreams ppEnumDebugStreams);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineFramesByAddr(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] uint isect,
			[In] uint offset,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineFramesByRVA(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] uint rva,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineFramesByVA(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] ulong va,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLines(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLinesByAddr(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] uint isect,
			[In] uint offset,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLinesByRVA(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] uint rva,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLinesByVA(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] ulong va,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineeLinesByLinenum(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol compiland,
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSourceFile file,
			[In] uint linenum,
			[In] uint column,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInlineesByName(
			[In][MarshalAs(UnmanagedType.LPWStr)] string name,
			[In] NameSearchOptions option,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findAcceleratorInlineeLinesByLinenum(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSourceFile file,
			[In] uint linenum,
			[In] uint column,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolsForAcceleratorPointerTag(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] uint tagValue,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findSymbolsByRVAForAcceleratorPointerTag(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol parent,
			[In] uint tagValue,
			[In] uint rva,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findAcceleratorInlineesByName(
			[In][MarshalAs(UnmanagedType.LPWStr)] string name,
			[In] NameSearchOptions option,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void addressForVA(
			[In] ulong va, 
			[Out] out uint pISect,
			[Out] out uint pOffset);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void addressForRVA(
			[In] uint rva,
			[Out]out uint pISect,
			[Out]out uint pOffset);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findILOffsetsByAddr(
			[In] uint isect,
			[In] uint offset,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findILOffsetsByRVA(
			[In] uint rva,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findILOffsetsByVA(
			[In] ulong va,
			[In] uint length,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInputAssemblyFiles(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumInputAssemblyFiles ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInputAssembly(
			[In] uint index,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaInputAssemblyFile ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInputAssemblyById(
			[In] uint uniqueId,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaInputAssemblyFile ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getFuncMDTokenMapSize(
			[Out]out uint pcb);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getFuncMDTokenMap(
			[In] uint cb,
			[Out]out uint pcb,
			[Out]out byte pb);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getTypeMDTokenMapSize(
			[Out]out uint pcb);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getTypeMDTokenMap(
			[In] uint cb,
			[Out]out uint pcb,
			[Out]out byte pb);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getNumberOfFunctionFragments_VA(
			[In] ulong vaFunc,
			[In] uint cbFunc,
			[Out]out uint pNumFragments);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getNumberOfFunctionFragments_RVA(
			[In] uint rvaFunc,
			[In] uint cbFunc,
			[Out]out uint pNumFragments);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getFunctionFragments_VA(
			[In] ulong vaFunc,
			[In] uint cbFunc,
			[In] uint cFragments,
			[Out]out ulong pVaFragment,
			[Out]out uint pLenFragment);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getFunctionFragments_RVA(
			[In] uint rvaFunc,
			[In] uint cbFunc,
			[In] uint cFragments,
			[Out]out uint pRvaFragment,
			[Out]out uint pLenFragment);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getExports(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getHeapAllocationSites(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppResult);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void findInputAssemblyFile(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaSymbol pSymbol,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaInputAssemblyFile ppResult);
	}
}
