﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_RenderTargetSetup : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.RenderTargetSetup o;
			if(matchType(l,argc,2,typeof(UnityEngine.RenderBuffer),typeof(UnityEngine.RenderBuffer))){
				UnityEngine.RenderBuffer a1;
				checkValueType(l,2,out a1);
				UnityEngine.RenderBuffer a2;
				checkValueType(l,3,out a2);
				o=new UnityEngine.RenderTargetSetup(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.RenderBuffer),typeof(UnityEngine.RenderBuffer),typeof(int))){
				UnityEngine.RenderBuffer a1;
				checkValueType(l,2,out a1);
				UnityEngine.RenderBuffer a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				o=new UnityEngine.RenderTargetSetup(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.RenderBuffer),typeof(UnityEngine.RenderBuffer),typeof(int),typeof(UnityEngine.CubemapFace))){
				UnityEngine.RenderBuffer a1;
				checkValueType(l,2,out a1);
				UnityEngine.RenderBuffer a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.CubemapFace a4;
				checkEnum(l,5,out a4);
				o=new UnityEngine.RenderTargetSetup(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.RenderBuffer[]),typeof(UnityEngine.RenderBuffer))){
				UnityEngine.RenderBuffer[] a1;
				checkType(l,2,out a1);
				UnityEngine.RenderBuffer a2;
				checkValueType(l,3,out a2);
				o=new UnityEngine.RenderTargetSetup(a1,a2);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.RenderBuffer[]),typeof(UnityEngine.RenderBuffer),typeof(int))){
				UnityEngine.RenderBuffer[] a1;
				checkType(l,2,out a1);
				UnityEngine.RenderBuffer a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				o=new UnityEngine.RenderTargetSetup(a1,a2,a3);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.RenderBuffer[]),typeof(UnityEngine.RenderBuffer),typeof(int),typeof(UnityEngine.CubemapFace))){
				UnityEngine.RenderBuffer[] a1;
				checkType(l,2,out a1);
				UnityEngine.RenderBuffer a2;
				checkValueType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				UnityEngine.CubemapFace a4;
				checkEnum(l,5,out a4);
				o=new UnityEngine.RenderTargetSetup(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_color(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.color);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_color(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.RenderBuffer[] v;
			checkType(l,2,out v);
			self.color=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depth(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.depth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depth(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.RenderBuffer v;
			checkValueType(l,2,out v);
			self.depth=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_mipLevel(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.mipLevel);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_mipLevel(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.mipLevel=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cubemapFace(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.cubemapFace);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cubemapFace(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			System.Int32 v;
			checkType(l,2,out v);
			self.cubemapFace=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorLoad(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorLoad);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorLoad(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferLoadAction[] v;
			checkType(l,2,out v);
			self.colorLoad=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_colorStore(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.colorStore);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_colorStore(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferStoreAction[] v;
			checkType(l,2,out v);
			self.colorStore=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthLoad(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.depthLoad);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depthLoad(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferLoadAction v;
			checkEnum(l,2,out v);
			self.depthLoad=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_depthStore(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushEnum(l,(int)self.depthStore);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_depthStore(IntPtr l) {
		try {
			UnityEngine.RenderTargetSetup self;
			checkValueType(l,1,out self);
			UnityEngine.Rendering.RenderBufferStoreAction v;
			checkEnum(l,2,out v);
			self.depthStore=v;
			setBack(l,self);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.RenderTargetSetup");
		addMember(l,"color",get_color,set_color,true);
		addMember(l,"depth",get_depth,set_depth,true);
		addMember(l,"mipLevel",get_mipLevel,set_mipLevel,true);
		addMember(l,"cubemapFace",get_cubemapFace,set_cubemapFace,true);
		addMember(l,"colorLoad",get_colorLoad,set_colorLoad,true);
		addMember(l,"colorStore",get_colorStore,set_colorStore,true);
		addMember(l,"depthLoad",get_depthLoad,set_depthLoad,true);
		addMember(l,"depthStore",get_depthStore,set_depthStore,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.RenderTargetSetup),typeof(System.ValueType));
	}
}
