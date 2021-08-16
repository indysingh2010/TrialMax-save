

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.00.0595 */
/* at Tue Jan 28 14:30:07 2014
 */
/* Compiler settings for Tm_print6.odl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.00.0595 
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__


#ifndef __Tm_print6_h__
#define __Tm_print6_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef ___DTMPrint6_FWD_DEFINED__
#define ___DTMPrint6_FWD_DEFINED__
typedef interface _DTMPrint6 _DTMPrint6;

#endif 	/* ___DTMPrint6_FWD_DEFINED__ */


#ifndef ___DTMPrint6Events_FWD_DEFINED__
#define ___DTMPrint6Events_FWD_DEFINED__
typedef interface _DTMPrint6Events _DTMPrint6Events;

#endif 	/* ___DTMPrint6Events_FWD_DEFINED__ */


#ifndef __TMPrint6_FWD_DEFINED__
#define __TMPrint6_FWD_DEFINED__

#ifdef __cplusplus
typedef class TMPrint6 TMPrint6;
#else
typedef struct TMPrint6 TMPrint6;
#endif /* __cplusplus */

#endif 	/* __TMPrint6_FWD_DEFINED__ */


#ifdef __cplusplus
extern "C"{
#endif 


/* interface __MIDL_itf_Tm_print6_0000_0000 */
/* [local] */ 

#pragma once
#pragma region Desktop Family
#pragma endregion


extern RPC_IF_HANDLE __MIDL_itf_Tm_print6_0000_0000_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_Tm_print6_0000_0000_v0_0_s_ifspec;


#ifndef __TM_PRINT6Lib_LIBRARY_DEFINED__
#define __TM_PRINT6Lib_LIBRARY_DEFINED__

/* library TM_PRINT6Lib */
/* [control][helpstring][helpfile][version][uuid] */ 


EXTERN_C const IID LIBID_TM_PRINT6Lib;

#ifndef ___DTMPrint6_DISPINTERFACE_DEFINED__
#define ___DTMPrint6_DISPINTERFACE_DEFINED__

/* dispinterface _DTMPrint6 */
/* [hidden][helpstring][uuid] */ 


EXTERN_C const IID DIID__DTMPrint6;

#if defined(__cplusplus) && !defined(CINTERFACE)

    MIDL_INTERFACE("02EABDFE-378F-4F1D-9CC9-E811052011A3")
    _DTMPrint6 : public IDispatch
    {
    };
    
#else 	/* C style interface */

    typedef struct _DTMPrint6Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            _DTMPrint6 * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            _DTMPrint6 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            _DTMPrint6 * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            _DTMPrint6 * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            _DTMPrint6 * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            _DTMPrint6 * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            _DTMPrint6 * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        END_INTERFACE
    } _DTMPrint6Vtbl;

    interface _DTMPrint6
    {
        CONST_VTBL struct _DTMPrint6Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define _DTMPrint6_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define _DTMPrint6_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define _DTMPrint6_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define _DTMPrint6_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define _DTMPrint6_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define _DTMPrint6_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define _DTMPrint6_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */


#endif 	/* ___DTMPrint6_DISPINTERFACE_DEFINED__ */


#ifndef ___DTMPrint6Events_DISPINTERFACE_DEFINED__
#define ___DTMPrint6Events_DISPINTERFACE_DEFINED__

/* dispinterface _DTMPrint6Events */
/* [helpstring][uuid] */ 


EXTERN_C const IID DIID__DTMPrint6Events;

#if defined(__cplusplus) && !defined(CINTERFACE)

    MIDL_INTERFACE("644C7420-E402-4A84-8D38-EDAD797B33EA")
    _DTMPrint6Events : public IDispatch
    {
    };
    
#else 	/* C style interface */

    typedef struct _DTMPrint6EventsVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            _DTMPrint6Events * This,
            /* [in] */ REFIID riid,
            /* [annotation][iid_is][out] */ 
            _COM_Outptr_  void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            _DTMPrint6Events * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            _DTMPrint6Events * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            _DTMPrint6Events * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            _DTMPrint6Events * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            _DTMPrint6Events * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [range][in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            _DTMPrint6Events * This,
            /* [annotation][in] */ 
            _In_  DISPID dispIdMember,
            /* [annotation][in] */ 
            _In_  REFIID riid,
            /* [annotation][in] */ 
            _In_  LCID lcid,
            /* [annotation][in] */ 
            _In_  WORD wFlags,
            /* [annotation][out][in] */ 
            _In_  DISPPARAMS *pDispParams,
            /* [annotation][out] */ 
            _Out_opt_  VARIANT *pVarResult,
            /* [annotation][out] */ 
            _Out_opt_  EXCEPINFO *pExcepInfo,
            /* [annotation][out] */ 
            _Out_opt_  UINT *puArgErr);
        
        END_INTERFACE
    } _DTMPrint6EventsVtbl;

    interface _DTMPrint6Events
    {
        CONST_VTBL struct _DTMPrint6EventsVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define _DTMPrint6Events_QueryInterface(This,riid,ppvObject)	\
    ( (This)->lpVtbl -> QueryInterface(This,riid,ppvObject) ) 

#define _DTMPrint6Events_AddRef(This)	\
    ( (This)->lpVtbl -> AddRef(This) ) 

#define _DTMPrint6Events_Release(This)	\
    ( (This)->lpVtbl -> Release(This) ) 


#define _DTMPrint6Events_GetTypeInfoCount(This,pctinfo)	\
    ( (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo) ) 

#define _DTMPrint6Events_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    ( (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo) ) 

#define _DTMPrint6Events_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    ( (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) ) 

#define _DTMPrint6Events_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    ( (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) ) 

#endif /* COBJMACROS */


#endif 	/* C style interface */


#endif 	/* ___DTMPrint6Events_DISPINTERFACE_DEFINED__ */


EXTERN_C const CLSID CLSID_TMPrint6;

#ifdef __cplusplus

class DECLSPEC_UUID("2B6165A5-C1FC-463E-9B56-20143BF4F627")
TMPrint6;
#endif
#endif /* __TM_PRINT6Lib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


