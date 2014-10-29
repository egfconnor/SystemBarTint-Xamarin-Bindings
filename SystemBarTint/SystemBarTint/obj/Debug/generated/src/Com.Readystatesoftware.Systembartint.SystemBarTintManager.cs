using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Readystatesoftware.Systembartint {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']"
	[global::Android.Runtime.Register ("com/readystatesoftware/systembartint/SystemBarTintManager", DoNotGenerateAcw=true)]
	public partial class SystemBarTintManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/field[@name='DEFAULT_TINT_COLOR']"
		[Register ("DEFAULT_TINT_COLOR")]
		public const int DefaultTintColor = (int) -1728053248;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']"
		[global::Android.Runtime.Register ("com/readystatesoftware/systembartint/SystemBarTintManager$SystemBarConfig", DoNotGenerateAcw=true)]
		public partial class SystemBarConfig : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/readystatesoftware/systembartint/SystemBarTintManager$SystemBarConfig", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SystemBarConfig); }
			}

			protected SystemBarConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getActionBarHeight;
#pragma warning disable 0169
			static Delegate GetGetActionBarHeightHandler ()
			{
				if (cb_getActionBarHeight == null)
					cb_getActionBarHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetActionBarHeight);
				return cb_getActionBarHeight;
			}

			static int n_GetActionBarHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ActionBarHeight;
			}
#pragma warning restore 0169

			static IntPtr id_getActionBarHeight;
			public virtual int ActionBarHeight {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='getActionBarHeight' and count(parameter)=0]"
				[Register ("getActionBarHeight", "()I", "GetGetActionBarHeightHandler")]
				get {
					if (id_getActionBarHeight == IntPtr.Zero)
						id_getActionBarHeight = JNIEnv.GetMethodID (class_ref, "getActionBarHeight", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getActionBarHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getActionBarHeight", "()I"));
				}
			}

			static Delegate cb_hasNavigtionBar;
#pragma warning disable 0169
			static Delegate GetHasNavigtionBarHandler ()
			{
				if (cb_hasNavigtionBar == null)
					cb_hasNavigtionBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNavigtionBar);
				return cb_hasNavigtionBar;
			}

			static bool n_HasNavigtionBar (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNavigtionBar;
			}
#pragma warning restore 0169

			static IntPtr id_hasNavigtionBar;
			public virtual bool HasNavigtionBar {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='hasNavigtionBar' and count(parameter)=0]"
				[Register ("hasNavigtionBar", "()Z", "GetHasNavigtionBarHandler")]
				get {
					if (id_hasNavigtionBar == IntPtr.Zero)
						id_hasNavigtionBar = JNIEnv.GetMethodID (class_ref, "hasNavigtionBar", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasNavigtionBar);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasNavigtionBar", "()Z"));
				}
			}

			static Delegate cb_isNavigationAtBottom;
#pragma warning disable 0169
			static Delegate GetIsNavigationAtBottomHandler ()
			{
				if (cb_isNavigationAtBottom == null)
					cb_isNavigationAtBottom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNavigationAtBottom);
				return cb_isNavigationAtBottom;
			}

			static bool n_IsNavigationAtBottom (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsNavigationAtBottom;
			}
#pragma warning restore 0169

			static IntPtr id_isNavigationAtBottom;
			public virtual bool IsNavigationAtBottom {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='isNavigationAtBottom' and count(parameter)=0]"
				[Register ("isNavigationAtBottom", "()Z", "GetIsNavigationAtBottomHandler")]
				get {
					if (id_isNavigationAtBottom == IntPtr.Zero)
						id_isNavigationAtBottom = JNIEnv.GetMethodID (class_ref, "isNavigationAtBottom", "()Z");

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isNavigationAtBottom);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNavigationAtBottom", "()Z"));
				}
			}

			static Delegate cb_getNavigationBarHeight;
#pragma warning disable 0169
			static Delegate GetGetNavigationBarHeightHandler ()
			{
				if (cb_getNavigationBarHeight == null)
					cb_getNavigationBarHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationBarHeight);
				return cb_getNavigationBarHeight;
			}

			static int n_GetNavigationBarHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NavigationBarHeight;
			}
#pragma warning restore 0169

			static IntPtr id_getNavigationBarHeight;
			public virtual int NavigationBarHeight {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='getNavigationBarHeight' and count(parameter)=0]"
				[Register ("getNavigationBarHeight", "()I", "GetGetNavigationBarHeightHandler")]
				get {
					if (id_getNavigationBarHeight == IntPtr.Zero)
						id_getNavigationBarHeight = JNIEnv.GetMethodID (class_ref, "getNavigationBarHeight", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNavigationBarHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNavigationBarHeight", "()I"));
				}
			}

			static Delegate cb_getNavigationBarWidth;
#pragma warning disable 0169
			static Delegate GetGetNavigationBarWidthHandler ()
			{
				if (cb_getNavigationBarWidth == null)
					cb_getNavigationBarWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationBarWidth);
				return cb_getNavigationBarWidth;
			}

			static int n_GetNavigationBarWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NavigationBarWidth;
			}
#pragma warning restore 0169

			static IntPtr id_getNavigationBarWidth;
			public virtual int NavigationBarWidth {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='getNavigationBarWidth' and count(parameter)=0]"
				[Register ("getNavigationBarWidth", "()I", "GetGetNavigationBarWidthHandler")]
				get {
					if (id_getNavigationBarWidth == IntPtr.Zero)
						id_getNavigationBarWidth = JNIEnv.GetMethodID (class_ref, "getNavigationBarWidth", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getNavigationBarWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNavigationBarWidth", "()I"));
				}
			}

			static Delegate cb_getPixelInsetBottom;
#pragma warning disable 0169
			static Delegate GetGetPixelInsetBottomHandler ()
			{
				if (cb_getPixelInsetBottom == null)
					cb_getPixelInsetBottom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPixelInsetBottom);
				return cb_getPixelInsetBottom;
			}

			static int n_GetPixelInsetBottom (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PixelInsetBottom;
			}
#pragma warning restore 0169

			static IntPtr id_getPixelInsetBottom;
			public virtual int PixelInsetBottom {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='getPixelInsetBottom' and count(parameter)=0]"
				[Register ("getPixelInsetBottom", "()I", "GetGetPixelInsetBottomHandler")]
				get {
					if (id_getPixelInsetBottom == IntPtr.Zero)
						id_getPixelInsetBottom = JNIEnv.GetMethodID (class_ref, "getPixelInsetBottom", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPixelInsetBottom);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixelInsetBottom", "()I"));
				}
			}

			static Delegate cb_getPixelInsetRight;
#pragma warning disable 0169
			static Delegate GetGetPixelInsetRightHandler ()
			{
				if (cb_getPixelInsetRight == null)
					cb_getPixelInsetRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPixelInsetRight);
				return cb_getPixelInsetRight;
			}

			static int n_GetPixelInsetRight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.PixelInsetRight;
			}
#pragma warning restore 0169

			static IntPtr id_getPixelInsetRight;
			public virtual int PixelInsetRight {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='getPixelInsetRight' and count(parameter)=0]"
				[Register ("getPixelInsetRight", "()I", "GetGetPixelInsetRightHandler")]
				get {
					if (id_getPixelInsetRight == IntPtr.Zero)
						id_getPixelInsetRight = JNIEnv.GetMethodID (class_ref, "getPixelInsetRight", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getPixelInsetRight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixelInsetRight", "()I"));
				}
			}

			static Delegate cb_getStatusBarHeight;
#pragma warning disable 0169
			static Delegate GetGetStatusBarHeightHandler ()
			{
				if (cb_getStatusBarHeight == null)
					cb_getStatusBarHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusBarHeight);
				return cb_getStatusBarHeight;
			}

			static int n_GetStatusBarHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.StatusBarHeight;
			}
#pragma warning restore 0169

			static IntPtr id_getStatusBarHeight;
			public virtual int StatusBarHeight {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='getStatusBarHeight' and count(parameter)=0]"
				[Register ("getStatusBarHeight", "()I", "GetGetStatusBarHeightHandler")]
				get {
					if (id_getStatusBarHeight == IntPtr.Zero)
						id_getStatusBarHeight = JNIEnv.GetMethodID (class_ref, "getStatusBarHeight", "()I");

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getStatusBarHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusBarHeight", "()I"));
				}
			}

			static Delegate cb_getPixelInsetTop_Z;
#pragma warning disable 0169
			static Delegate GetGetPixelInsetTop_ZHandler ()
			{
				if (cb_getPixelInsetTop_Z == null)
					cb_getPixelInsetTop_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, int>) n_GetPixelInsetTop_Z);
				return cb_getPixelInsetTop_Z;
			}

			static int n_GetPixelInsetTop_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetPixelInsetTop (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getPixelInsetTop_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager.SystemBarConfig']/method[@name='getPixelInsetTop' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("getPixelInsetTop", "(Z)I", "GetGetPixelInsetTop_ZHandler")]
			public virtual int GetPixelInsetTop (bool p0)
			{
				if (id_getPixelInsetTop_Z == IntPtr.Zero)
					id_getPixelInsetTop_Z = JNIEnv.GetMethodID (class_ref, "getPixelInsetTop", "(Z)I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getPixelInsetTop_Z, new JValue (p0));
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPixelInsetTop", "(Z)I"), new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/readystatesoftware/systembartint/SystemBarTintManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SystemBarTintManager); }
		}

		protected SystemBarTintManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/constructor[@name='SystemBarTintManager' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public SystemBarTintManager (global::Android.App.Activity p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (SystemBarTintManager)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
				id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		static IntPtr id_getConfig;
		public virtual global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lcom/readystatesoftware/systembartint/SystemBarTintManager$SystemBarConfig;", "GetGetConfigHandler")]
			get {
				if (id_getConfig == IntPtr.Zero)
					id_getConfig = JNIEnv.GetMethodID (class_ref, "getConfig", "()Lcom/readystatesoftware/systembartint/SystemBarTintManager$SystemBarConfig;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (JNIEnv.CallObjectMethod  (Handle, id_getConfig), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager.SystemBarConfig> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "()Lcom/readystatesoftware/systembartint/SystemBarTintManager$SystemBarConfig;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isNavBarTintEnabled;
#pragma warning disable 0169
		static Delegate GetIsNavBarTintEnabledHandler ()
		{
			if (cb_isNavBarTintEnabled == null)
				cb_isNavBarTintEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNavBarTintEnabled);
			return cb_isNavBarTintEnabled;
		}

		static bool n_IsNavBarTintEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNavBarTintEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isNavBarTintEnabled;
		public virtual bool IsNavBarTintEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='isNavBarTintEnabled' and count(parameter)=0]"
			[Register ("isNavBarTintEnabled", "()Z", "GetIsNavBarTintEnabledHandler")]
			get {
				if (id_isNavBarTintEnabled == IntPtr.Zero)
					id_isNavBarTintEnabled = JNIEnv.GetMethodID (class_ref, "isNavBarTintEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isNavBarTintEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNavBarTintEnabled", "()Z"));
			}
		}

		static Delegate cb_isStatusBarTintEnabled;
#pragma warning disable 0169
		static Delegate GetIsStatusBarTintEnabledHandler ()
		{
			if (cb_isStatusBarTintEnabled == null)
				cb_isStatusBarTintEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStatusBarTintEnabled);
			return cb_isStatusBarTintEnabled;
		}

		static bool n_IsStatusBarTintEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusBarTintEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setStatusBarTintEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetStatusBarTintEnabled_ZHandler ()
		{
			if (cb_setStatusBarTintEnabled_Z == null)
				cb_setStatusBarTintEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetStatusBarTintEnabled_Z);
			return cb_setStatusBarTintEnabled_Z;
		}

		static void n_SetStatusBarTintEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StatusBarTintEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isStatusBarTintEnabled;
		static IntPtr id_setStatusBarTintEnabled_Z;
		public virtual bool StatusBarTintEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='isStatusBarTintEnabled' and count(parameter)=0]"
			[Register ("isStatusBarTintEnabled", "()Z", "GetIsStatusBarTintEnabledHandler")]
			get {
				if (id_isStatusBarTintEnabled == IntPtr.Zero)
					id_isStatusBarTintEnabled = JNIEnv.GetMethodID (class_ref, "isStatusBarTintEnabled", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isStatusBarTintEnabled);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStatusBarTintEnabled", "()Z"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setStatusBarTintEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStatusBarTintEnabled", "(Z)V", "GetSetStatusBarTintEnabled_ZHandler")]
			set {
				if (id_setStatusBarTintEnabled_Z == IntPtr.Zero)
					id_setStatusBarTintEnabled_Z = JNIEnv.GetMethodID (class_ref, "setStatusBarTintEnabled", "(Z)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setStatusBarTintEnabled_Z, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusBarTintEnabled", "(Z)V"), new JValue (value));
			}
		}

		static Delegate cb_setNavigationBarAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetNavigationBarAlpha_FHandler ()
		{
			if (cb_setNavigationBarAlpha_F == null)
				cb_setNavigationBarAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetNavigationBarAlpha_F);
			return cb_setNavigationBarAlpha_F;
		}

		static void n_SetNavigationBarAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNavigationBarAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNavigationBarAlpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setNavigationBarAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setNavigationBarAlpha", "(F)V", "GetSetNavigationBarAlpha_FHandler")]
		public virtual void SetNavigationBarAlpha (float p0)
		{
			if (id_setNavigationBarAlpha_F == IntPtr.Zero)
				id_setNavigationBarAlpha_F = JNIEnv.GetMethodID (class_ref, "setNavigationBarAlpha", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNavigationBarAlpha_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNavigationBarAlpha", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setNavigationBarTintColor_I;
#pragma warning disable 0169
		static Delegate GetSetNavigationBarTintColor_IHandler ()
		{
			if (cb_setNavigationBarTintColor_I == null)
				cb_setNavigationBarTintColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNavigationBarTintColor_I);
			return cb_setNavigationBarTintColor_I;
		}

		static void n_SetNavigationBarTintColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNavigationBarTintColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNavigationBarTintColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setNavigationBarTintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNavigationBarTintColor", "(I)V", "GetSetNavigationBarTintColor_IHandler")]
		public virtual void SetNavigationBarTintColor (int p0)
		{
			if (id_setNavigationBarTintColor_I == IntPtr.Zero)
				id_setNavigationBarTintColor_I = JNIEnv.GetMethodID (class_ref, "setNavigationBarTintColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNavigationBarTintColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNavigationBarTintColor", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNavigationBarTintDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setNavigationBarTintDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setNavigationBarTintDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetNavigationBarTintDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setNavigationBarTintDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNavigationBarTintDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNavigationBarTintDrawable", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setNavigationBarTintEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetNavigationBarTintEnabled_ZHandler ()
		{
			if (cb_setNavigationBarTintEnabled_Z == null)
				cb_setNavigationBarTintEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNavigationBarTintEnabled_Z);
			return cb_setNavigationBarTintEnabled_Z;
		}

		static void n_SetNavigationBarTintEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNavigationBarTintEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNavigationBarTintEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setNavigationBarTintEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNavigationBarTintEnabled", "(Z)V", "GetSetNavigationBarTintEnabled_ZHandler")]
		public virtual void SetNavigationBarTintEnabled (bool p0)
		{
			if (id_setNavigationBarTintEnabled_Z == IntPtr.Zero)
				id_setNavigationBarTintEnabled_Z = JNIEnv.GetMethodID (class_ref, "setNavigationBarTintEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNavigationBarTintEnabled_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNavigationBarTintEnabled", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setNavigationBarTintResource_I;
#pragma warning disable 0169
		static Delegate GetSetNavigationBarTintResource_IHandler ()
		{
			if (cb_setNavigationBarTintResource_I == null)
				cb_setNavigationBarTintResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNavigationBarTintResource_I);
			return cb_setNavigationBarTintResource_I;
		}

		static void n_SetNavigationBarTintResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNavigationBarTintResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNavigationBarTintResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setNavigationBarTintResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNavigationBarTintResource", "(I)V", "GetSetNavigationBarTintResource_IHandler")]
		public virtual void SetNavigationBarTintResource (int p0)
		{
			if (id_setNavigationBarTintResource_I == IntPtr.Zero)
				id_setNavigationBarTintResource_I = JNIEnv.GetMethodID (class_ref, "setNavigationBarTintResource", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNavigationBarTintResource_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNavigationBarTintResource", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setStatusBarAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetStatusBarAlpha_FHandler ()
		{
			if (cb_setStatusBarAlpha_F == null)
				cb_setStatusBarAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStatusBarAlpha_F);
			return cb_setStatusBarAlpha_F;
		}

		static void n_SetStatusBarAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatusBarAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatusBarAlpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setStatusBarAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setStatusBarAlpha", "(F)V", "GetSetStatusBarAlpha_FHandler")]
		public virtual void SetStatusBarAlpha (float p0)
		{
			if (id_setStatusBarAlpha_F == IntPtr.Zero)
				id_setStatusBarAlpha_F = JNIEnv.GetMethodID (class_ref, "setStatusBarAlpha", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStatusBarAlpha_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusBarAlpha", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setStatusBarTintColor_I;
#pragma warning disable 0169
		static Delegate GetSetStatusBarTintColor_IHandler ()
		{
			if (cb_setStatusBarTintColor_I == null)
				cb_setStatusBarTintColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatusBarTintColor_I);
			return cb_setStatusBarTintColor_I;
		}

		static void n_SetStatusBarTintColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatusBarTintColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatusBarTintColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setStatusBarTintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatusBarTintColor", "(I)V", "GetSetStatusBarTintColor_IHandler")]
		public virtual void SetStatusBarTintColor (int p0)
		{
			if (id_setStatusBarTintColor_I == IntPtr.Zero)
				id_setStatusBarTintColor_I = JNIEnv.GetMethodID (class_ref, "setStatusBarTintColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStatusBarTintColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusBarTintColor", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStatusBarTintDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setStatusBarTintDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setStatusBarTintDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetStatusBarTintDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setStatusBarTintDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStatusBarTintDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusBarTintDrawable", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setStatusBarTintResource_I;
#pragma warning disable 0169
		static Delegate GetSetStatusBarTintResource_IHandler ()
		{
			if (cb_setStatusBarTintResource_I == null)
				cb_setStatusBarTintResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatusBarTintResource_I);
			return cb_setStatusBarTintResource_I;
		}

		static void n_SetStatusBarTintResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStatusBarTintResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStatusBarTintResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setStatusBarTintResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setStatusBarTintResource", "(I)V", "GetSetStatusBarTintResource_IHandler")]
		public virtual void SetStatusBarTintResource (int p0)
		{
			if (id_setStatusBarTintResource_I == IntPtr.Zero)
				id_setStatusBarTintResource_I = JNIEnv.GetMethodID (class_ref, "setStatusBarTintResource", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setStatusBarTintResource_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusBarTintResource", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setTintAlpha_F;
#pragma warning disable 0169
		static Delegate GetSetTintAlpha_FHandler ()
		{
			if (cb_setTintAlpha_F == null)
				cb_setTintAlpha_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTintAlpha_F);
			return cb_setTintAlpha_F;
		}

		static void n_SetTintAlpha_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTintAlpha (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTintAlpha_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setTintAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTintAlpha", "(F)V", "GetSetTintAlpha_FHandler")]
		public virtual void SetTintAlpha (float p0)
		{
			if (id_setTintAlpha_F == IntPtr.Zero)
				id_setTintAlpha_F = JNIEnv.GetMethodID (class_ref, "setTintAlpha", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTintAlpha_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTintAlpha", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setTintColor_I;
#pragma warning disable 0169
		static Delegate GetSetTintColor_IHandler ()
		{
			if (cb_setTintColor_I == null)
				cb_setTintColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTintColor_I);
			return cb_setTintColor_I;
		}

		static void n_SetTintColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTintColor (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTintColor_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setTintColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTintColor", "(I)V", "GetSetTintColor_IHandler")]
		public virtual void SetTintColor (int p0)
		{
			if (id_setTintColor_I == IntPtr.Zero)
				id_setTintColor_I = JNIEnv.GetMethodID (class_ref, "setTintColor", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTintColor_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTintColor", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setTintDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetTintDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setTintDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setTintDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTintDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setTintDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetTintDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTintDrawable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTintDrawable_Landroid_graphics_drawable_Drawable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setTintDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setTintDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetTintDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual void SetTintDrawable (global::Android.Graphics.Drawables.Drawable p0)
		{
			if (id_setTintDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				id_setTintDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID (class_ref, "setTintDrawable", "(Landroid/graphics/drawable/Drawable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTintDrawable_Landroid_graphics_drawable_Drawable_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTintDrawable", "(Landroid/graphics/drawable/Drawable;)V"), new JValue (p0));
		}

		static Delegate cb_setTintResource_I;
#pragma warning disable 0169
		static Delegate GetSetTintResource_IHandler ()
		{
			if (cb_setTintResource_I == null)
				cb_setTintResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTintResource_I);
			return cb_setTintResource_I;
		}

		static void n_SetTintResource_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Readystatesoftware.Systembartint.SystemBarTintManager __this = global::Java.Lang.Object.GetObject<global::Com.Readystatesoftware.Systembartint.SystemBarTintManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTintResource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTintResource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.readystatesoftware.systembartint']/class[@name='SystemBarTintManager']/method[@name='setTintResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTintResource", "(I)V", "GetSetTintResource_IHandler")]
		public virtual void SetTintResource (int p0)
		{
			if (id_setTintResource_I == IntPtr.Zero)
				id_setTintResource_I = JNIEnv.GetMethodID (class_ref, "setTintResource", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTintResource_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTintResource", "(I)V"), new JValue (p0));
		}

	}
}
