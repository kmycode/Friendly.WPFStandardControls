﻿using Codeer.Friendly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace RM.Friendly.WPFStandardControls
{
#if ENG
    /// <summary>
    /// Provides operations on controls of type System.Windows.Controls.Slider.
    /// </summary>
#else
    /// <summary>
    /// TypeがSystem.Windows.Controls.Sliderのウィンドウに対応した操作を提供します。
    /// </summary>
#endif
    public class WPFSlider : WPFControlBase
    {
#if ENG
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="appVar">Application variable object for the control.</param>
#else
        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="appVar">アプリケーション内変数。</param>
#endif
        public WPFSlider(AppVar appVar)
            : base(appVar) { }

#if ENG
        /// <summary>
        /// Returns the control's value.
        /// </summary>
#else
        /// <summary>
        /// 値を取得します。
        /// </summary>
#endif
        public double Value
        {
            get { return Getter<double>("Value"); }
        }

#if ENG
        /// <summary>
        /// Sets the control's value.
        /// </summary>
        /// <param name="text">value to use.</param>
#else
        /// <summary>
        /// 値を変更します。
        /// </summary>
        /// <param name="value">値</param>
#endif
        public void EmulateChangeValue(double value)
        {
            InTarget("EmulateChangeValue", value);
        }
#if ENG
        /// <summary>
        /// Sets the control's value.
        /// Executes asynchronously. 
        /// </summary>
        /// <param name="value">value to use.</param>
        /// <param name="async">Asynchronous execution.</param>
#else
        /// <summary>
        /// 値を変更します。
        /// 非同期で実行します。
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="async">非同期実行オブジェクト</param>
#endif
        public void EmulateChangeValue(double value, Async async)
        {
            InTarget("EmulateChangeValue", async, value);
        }

        static void EmulateChangeValueInTarget(Slider slider, double value)
        {
            slider.Value = value;
        }
    }
}