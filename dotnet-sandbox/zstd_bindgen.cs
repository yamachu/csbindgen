// <auto-generated>
// This code is generated via csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
using System;
using System.Runtime.InteropServices;

namespace CsBindgen
{
    using ZSTD_CCtx = ZSTD_CCtx_s;
    using ZSTD_CDict = ZSTD_CDict_s;
    using ZSTD_CStream = ZSTD_CCtx_s;
    using ZSTD_DCtx = ZSTD_DCtx_s;
    using ZSTD_DDict = ZSTD_DDict_s;
    using ZSTD_DStream = ZSTD_DCtx_s;
    using ZSTD_EndDirective = Int32;
    using ZSTD_ResetDirective = Int32;
    using ZSTD_cParameter = Int32;
    using ZSTD_dParameter = Int32;
    using ZSTD_inBuffer = ZSTD_inBuffer_s;
    using ZSTD_outBuffer = ZSTD_outBuffer_s;


    public static unsafe partial class NativeMethods
    {
        const string __DllName = "";

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void __va_start(Byte** arg1);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void __security_init_cookie();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void __security_check_cookie(UIntPtr _StackCookie);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 ZSTD_versionNumber();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Byte* ZSTD_versionString();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_compress(void* dst, UIntPtr dstCapacity, void* src, UIntPtr srcSize, Int32 compressionLevel);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_decompress(void* dst, UIntPtr dstCapacity, void* src, UIntPtr compressedSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt64 ZSTD_getFrameContentSize(void* src, UIntPtr srcSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt64 ZSTD_getDecompressedSize(void* src, UIntPtr srcSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_findFrameCompressedSize(void* src, UIntPtr srcSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_compressBound(UIntPtr srcSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 ZSTD_isError(UIntPtr code);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Byte* ZSTD_getErrorName(UIntPtr code);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 ZSTD_minCLevel();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 ZSTD_maxCLevel();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 ZSTD_defaultCLevel();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ZSTD_CCtx* ZSTD_createCCtx();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_freeCCtx(ZSTD_CCtx* cctx);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_compressCCtx(ZSTD_CCtx* cctx, void* dst, UIntPtr dstCapacity, void* src, UIntPtr srcSize, Int32 compressionLevel);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ZSTD_DCtx* ZSTD_createDCtx();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_freeDCtx(ZSTD_DCtx* dctx);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_decompressDCtx(ZSTD_DCtx* dctx, void* dst, UIntPtr dstCapacity, void* src, UIntPtr srcSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ZSTD_bounds ZSTD_cParam_getBounds(ZSTD_cParameter cParam);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_CCtx_setParameter(ZSTD_CCtx* cctx, ZSTD_cParameter param, Int32 value);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_CCtx_setPledgedSrcSize(ZSTD_CCtx* cctx, UInt64 pledgedSrcSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_CCtx_reset(ZSTD_CCtx* cctx, ZSTD_ResetDirective reset);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_compress2(ZSTD_CCtx* cctx, void* dst, UIntPtr dstCapacity, void* src, UIntPtr srcSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ZSTD_bounds ZSTD_dParam_getBounds(ZSTD_dParameter dParam);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_DCtx_setParameter(ZSTD_DCtx* dctx, ZSTD_dParameter param, Int32 value);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_DCtx_reset(ZSTD_DCtx* dctx, ZSTD_ResetDirective reset);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ZSTD_CStream* ZSTD_createCStream();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_freeCStream(ZSTD_CStream* zcs);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_compressStream2(ZSTD_CCtx* cctx, ZSTD_outBuffer* output, ZSTD_inBuffer* input, ZSTD_EndDirective endOp);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_CStreamInSize();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_CStreamOutSize();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_initCStream(ZSTD_CStream* zcs, Int32 compressionLevel);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_compressStream(ZSTD_CStream* zcs, ZSTD_outBuffer* output, ZSTD_inBuffer* input);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_flushStream(ZSTD_CStream* zcs, ZSTD_outBuffer* output);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_endStream(ZSTD_CStream* zcs, ZSTD_outBuffer* output);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ZSTD_DStream* ZSTD_createDStream();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_freeDStream(ZSTD_DStream* zds);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_initDStream(ZSTD_DStream* zds);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_decompressStream(ZSTD_DStream* zds, ZSTD_outBuffer* output, ZSTD_inBuffer* input);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_DStreamInSize();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_DStreamOutSize();

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_compress_usingDict(ZSTD_CCtx* ctx, void* dst, UIntPtr dstCapacity, void* src, UIntPtr srcSize, void* dict, UIntPtr dictSize, Int32 compressionLevel);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_decompress_usingDict(ZSTD_DCtx* dctx, void* dst, UIntPtr dstCapacity, void* src, UIntPtr srcSize, void* dict, UIntPtr dictSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ZSTD_CDict* ZSTD_createCDict(void* dictBuffer, UIntPtr dictSize, Int32 compressionLevel);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_freeCDict(ZSTD_CDict* CDict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_compress_usingCDict(ZSTD_CCtx* cctx, void* dst, UIntPtr dstCapacity, void* src, UIntPtr srcSize, ZSTD_CDict* cdict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ZSTD_DDict* ZSTD_createDDict(void* dictBuffer, UIntPtr dictSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_freeDDict(ZSTD_DDict* ddict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_decompress_usingDDict(ZSTD_DCtx* dctx, void* dst, UIntPtr dstCapacity, void* src, UIntPtr srcSize, ZSTD_DDict* ddict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 ZSTD_getDictID_fromDict(void* dict, UIntPtr dictSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 ZSTD_getDictID_fromCDict(ZSTD_CDict* cdict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 ZSTD_getDictID_fromDDict(ZSTD_DDict* ddict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 ZSTD_getDictID_fromFrame(void* src, UIntPtr srcSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_CCtx_loadDictionary(ZSTD_CCtx* cctx, void* dict, UIntPtr dictSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_CCtx_refCDict(ZSTD_CCtx* cctx, ZSTD_CDict* cdict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_CCtx_refPrefix(ZSTD_CCtx* cctx, void* prefix, UIntPtr prefixSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_DCtx_loadDictionary(ZSTD_DCtx* dctx, void* dict, UIntPtr dictSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_DCtx_refDDict(ZSTD_DCtx* dctx, ZSTD_DDict* ddict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_DCtx_refPrefix(ZSTD_DCtx* dctx, void* prefix, UIntPtr prefixSize);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_sizeof_CCtx(ZSTD_CCtx* cctx);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_sizeof_DCtx(ZSTD_DCtx* dctx);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_sizeof_CStream(ZSTD_CStream* zcs);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_sizeof_DStream(ZSTD_DStream* zds);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_sizeof_CDict(ZSTD_CDict* cdict);

        [DllImport(__DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UIntPtr ZSTD_sizeof_DDict(ZSTD_DDict* ddict);


    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ZSTD_CCtx_s
    {
        public fixed Byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ZSTD_DCtx_s
    {
        public fixed Byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ZSTD_bounds
    {
        public UIntPtr error;
        public Int32 lowerBound;
        public Int32 upperBound;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ZSTD_inBuffer_s
    {
        public void* src;
        public UIntPtr size;
        public UIntPtr pos;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ZSTD_outBuffer_s
    {
        public void* dst;
        public UIntPtr size;
        public UIntPtr pos;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ZSTD_CDict_s
    {
        public fixed Byte _unused[1];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ZSTD_DDict_s
    {
        public fixed Byte _unused[1];
    }

    
}
    