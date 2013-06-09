﻿// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

#if !W8CORE && NET35Plus && !DIRECTX11_1

using System;
using System.Collections.Generic;
using WpfKeys = System.Windows.Input.Key;

namespace SharpDX.Toolkit.Input
{
    /// <summary>
    /// A specific implementation of <see cref="KeyboardPlatform"/> for desktop WPF platform
    /// </summary>
    internal sealed class KeyboardPlatformDesktopWpf : KeyboardPlatform
    {
        private static readonly IDictionary<WpfKeys, Keys> _keysDictionaryWpf;

        static KeyboardPlatformDesktopWpf()
        {
            _keysDictionaryWpf = new Dictionary<WpfKeys, Keys>();
            // the contents of this dictionary were autogenerated by comparing enum first by names, 
            // then, if no value is found, by int value.
            // the values that don't have a equivalent in either list are ignored.
            _keysDictionaryWpf[WpfKeys.None] = Keys.None;
            _keysDictionaryWpf[WpfKeys.Back] = Keys.Back;
            _keysDictionaryWpf[WpfKeys.Tab] = Keys.Tab;
            _keysDictionaryWpf[WpfKeys.Escape] = Keys.Enter;
            _keysDictionaryWpf[WpfKeys.ImeAccept] = Keys.Shift;
            _keysDictionaryWpf[WpfKeys.ImeModeChange] = Keys.Control;
            _keysDictionaryWpf[WpfKeys.Space] = Keys.Alt;
            _keysDictionaryWpf[WpfKeys.Pause] = Keys.Pause;
            _keysDictionaryWpf[WpfKeys.Next] = Keys.CapsLock;
            _keysDictionaryWpf[WpfKeys.End] = Keys.Kana;
            _keysDictionaryWpf[WpfKeys.Right] = Keys.Kanji;
            _keysDictionaryWpf[WpfKeys.Escape] = Keys.Escape;
            _keysDictionaryWpf[WpfKeys.ImeConvert] = Keys.ImeConvert;
            _keysDictionaryWpf[WpfKeys.Execute] = Keys.ImeNoConvert;
            _keysDictionaryWpf[WpfKeys.Space] = Keys.Space;
            _keysDictionaryWpf[WpfKeys.PageUp] = Keys.PageUp;
            _keysDictionaryWpf[WpfKeys.D0] = Keys.PageDown;
            _keysDictionaryWpf[WpfKeys.End] = Keys.End;
            _keysDictionaryWpf[WpfKeys.Home] = Keys.Home;
            _keysDictionaryWpf[WpfKeys.Left] = Keys.Left;
            _keysDictionaryWpf[WpfKeys.Up] = Keys.Up;
            _keysDictionaryWpf[WpfKeys.Right] = Keys.Right;
            _keysDictionaryWpf[WpfKeys.Down] = Keys.Down;
            _keysDictionaryWpf[WpfKeys.Select] = Keys.Select;
            _keysDictionaryWpf[WpfKeys.Print] = Keys.Print;
            _keysDictionaryWpf[WpfKeys.Execute] = Keys.Execute;
            _keysDictionaryWpf[WpfKeys.A] = Keys.PrintScreen;
            _keysDictionaryWpf[WpfKeys.Insert] = Keys.Insert;
            _keysDictionaryWpf[WpfKeys.Delete] = Keys.Delete;
            _keysDictionaryWpf[WpfKeys.Help] = Keys.Help;
            _keysDictionaryWpf[WpfKeys.D0] = Keys.D0;
            _keysDictionaryWpf[WpfKeys.D1] = Keys.D1;
            _keysDictionaryWpf[WpfKeys.D2] = Keys.D2;
            _keysDictionaryWpf[WpfKeys.D3] = Keys.D3;
            _keysDictionaryWpf[WpfKeys.D4] = Keys.D4;
            _keysDictionaryWpf[WpfKeys.D5] = Keys.D5;
            _keysDictionaryWpf[WpfKeys.D6] = Keys.D6;
            _keysDictionaryWpf[WpfKeys.D7] = Keys.D7;
            _keysDictionaryWpf[WpfKeys.D8] = Keys.D8;
            _keysDictionaryWpf[WpfKeys.D9] = Keys.D9;
            _keysDictionaryWpf[WpfKeys.A] = Keys.A;
            _keysDictionaryWpf[WpfKeys.B] = Keys.B;
            _keysDictionaryWpf[WpfKeys.C] = Keys.C;
            _keysDictionaryWpf[WpfKeys.D] = Keys.D;
            _keysDictionaryWpf[WpfKeys.E] = Keys.E;
            _keysDictionaryWpf[WpfKeys.F] = Keys.F;
            _keysDictionaryWpf[WpfKeys.G] = Keys.G;
            _keysDictionaryWpf[WpfKeys.H] = Keys.H;
            _keysDictionaryWpf[WpfKeys.I] = Keys.I;
            _keysDictionaryWpf[WpfKeys.J] = Keys.J;
            _keysDictionaryWpf[WpfKeys.K] = Keys.K;
            _keysDictionaryWpf[WpfKeys.L] = Keys.L;
            _keysDictionaryWpf[WpfKeys.M] = Keys.M;
            _keysDictionaryWpf[WpfKeys.N] = Keys.N;
            _keysDictionaryWpf[WpfKeys.O] = Keys.O;
            _keysDictionaryWpf[WpfKeys.P] = Keys.P;
            _keysDictionaryWpf[WpfKeys.Q] = Keys.Q;
            _keysDictionaryWpf[WpfKeys.R] = Keys.R;
            _keysDictionaryWpf[WpfKeys.S] = Keys.S;
            _keysDictionaryWpf[WpfKeys.T] = Keys.T;
            _keysDictionaryWpf[WpfKeys.U] = Keys.U;
            _keysDictionaryWpf[WpfKeys.V] = Keys.V;
            _keysDictionaryWpf[WpfKeys.W] = Keys.W;
            _keysDictionaryWpf[WpfKeys.X] = Keys.X;
            _keysDictionaryWpf[WpfKeys.Y] = Keys.Y;
            _keysDictionaryWpf[WpfKeys.Z] = Keys.Z;
            _keysDictionaryWpf[WpfKeys.F2] = Keys.LeftWindows;
            _keysDictionaryWpf[WpfKeys.F3] = Keys.RightWindows;
            _keysDictionaryWpf[WpfKeys.Apps] = Keys.Apps;
            _keysDictionaryWpf[WpfKeys.Sleep] = Keys.Sleep;
            _keysDictionaryWpf[WpfKeys.NumPad0] = Keys.NumPad0;
            _keysDictionaryWpf[WpfKeys.NumPad1] = Keys.NumPad1;
            _keysDictionaryWpf[WpfKeys.NumPad2] = Keys.NumPad2;
            _keysDictionaryWpf[WpfKeys.NumPad3] = Keys.NumPad3;
            _keysDictionaryWpf[WpfKeys.NumPad4] = Keys.NumPad4;
            _keysDictionaryWpf[WpfKeys.NumPad5] = Keys.NumPad5;
            _keysDictionaryWpf[WpfKeys.NumPad6] = Keys.NumPad6;
            _keysDictionaryWpf[WpfKeys.NumPad7] = Keys.NumPad7;
            _keysDictionaryWpf[WpfKeys.NumPad8] = Keys.NumPad8;
            _keysDictionaryWpf[WpfKeys.NumPad9] = Keys.NumPad9;
            _keysDictionaryWpf[WpfKeys.Multiply] = Keys.Multiply;
            _keysDictionaryWpf[WpfKeys.Add] = Keys.Add;
            _keysDictionaryWpf[WpfKeys.Separator] = Keys.Separator;
            _keysDictionaryWpf[WpfKeys.Subtract] = Keys.Subtract;
            _keysDictionaryWpf[WpfKeys.Decimal] = Keys.Decimal;
            _keysDictionaryWpf[WpfKeys.Divide] = Keys.Divide;
            _keysDictionaryWpf[WpfKeys.F1] = Keys.F1;
            _keysDictionaryWpf[WpfKeys.F2] = Keys.F2;
            _keysDictionaryWpf[WpfKeys.F3] = Keys.F3;
            _keysDictionaryWpf[WpfKeys.F4] = Keys.F4;
            _keysDictionaryWpf[WpfKeys.F5] = Keys.F5;
            _keysDictionaryWpf[WpfKeys.F6] = Keys.F6;
            _keysDictionaryWpf[WpfKeys.F7] = Keys.F7;
            _keysDictionaryWpf[WpfKeys.F8] = Keys.F8;
            _keysDictionaryWpf[WpfKeys.F9] = Keys.F9;
            _keysDictionaryWpf[WpfKeys.F10] = Keys.F10;
            _keysDictionaryWpf[WpfKeys.F11] = Keys.F11;
            _keysDictionaryWpf[WpfKeys.F12] = Keys.F12;
            _keysDictionaryWpf[WpfKeys.F13] = Keys.F13;
            _keysDictionaryWpf[WpfKeys.F14] = Keys.F14;
            _keysDictionaryWpf[WpfKeys.F15] = Keys.F15;
            _keysDictionaryWpf[WpfKeys.F16] = Keys.F16;
            _keysDictionaryWpf[WpfKeys.F17] = Keys.F17;
            _keysDictionaryWpf[WpfKeys.F18] = Keys.F18;
            _keysDictionaryWpf[WpfKeys.F19] = Keys.F19;
            _keysDictionaryWpf[WpfKeys.F20] = Keys.F20;
            _keysDictionaryWpf[WpfKeys.F21] = Keys.F21;
            _keysDictionaryWpf[WpfKeys.F22] = Keys.F22;
            _keysDictionaryWpf[WpfKeys.F23] = Keys.F23;
            _keysDictionaryWpf[WpfKeys.F24] = Keys.F24;
            _keysDictionaryWpf[WpfKeys.NumLock] = Keys.NumLock;
            _keysDictionaryWpf[WpfKeys.Scroll] = Keys.Scroll;
            _keysDictionaryWpf[WpfKeys.LeftShift] = Keys.LeftShift;
            _keysDictionaryWpf[WpfKeys.RightShift] = Keys.RightShift;
            _keysDictionaryWpf[WpfKeys.OemBackTab] = Keys.LeftControl;
            _keysDictionaryWpf[WpfKeys.DbeNoRoman] = Keys.RightControl;
            _keysDictionaryWpf[WpfKeys.LeftAlt] = Keys.LeftAlt;
            _keysDictionaryWpf[WpfKeys.RightAlt] = Keys.RightAlt;
            _keysDictionaryWpf[WpfKeys.BrowserBack] = Keys.BrowserBack;
            _keysDictionaryWpf[WpfKeys.BrowserForward] = Keys.BrowserForward;
            _keysDictionaryWpf[WpfKeys.BrowserRefresh] = Keys.BrowserRefresh;
            _keysDictionaryWpf[WpfKeys.BrowserStop] = Keys.BrowserStop;
            _keysDictionaryWpf[WpfKeys.BrowserSearch] = Keys.BrowserSearch;
            _keysDictionaryWpf[WpfKeys.BrowserFavorites] = Keys.BrowserFavorites;
            _keysDictionaryWpf[WpfKeys.BrowserHome] = Keys.BrowserHome;
            _keysDictionaryWpf[WpfKeys.VolumeMute] = Keys.VolumeMute;
            _keysDictionaryWpf[WpfKeys.VolumeDown] = Keys.VolumeDown;
            _keysDictionaryWpf[WpfKeys.VolumeUp] = Keys.VolumeUp;
            _keysDictionaryWpf[WpfKeys.MediaNextTrack] = Keys.MediaNextTrack;
            _keysDictionaryWpf[WpfKeys.MediaPreviousTrack] = Keys.MediaPreviousTrack;
            _keysDictionaryWpf[WpfKeys.MediaStop] = Keys.MediaStop;
            _keysDictionaryWpf[WpfKeys.MediaPlayPause] = Keys.MediaPlayPause;
            _keysDictionaryWpf[WpfKeys.LaunchMail] = Keys.LaunchMail;
            _keysDictionaryWpf[WpfKeys.SelectMedia] = Keys.SelectMedia;
            _keysDictionaryWpf[WpfKeys.LaunchApplication1] = Keys.LaunchApplication1;
            _keysDictionaryWpf[WpfKeys.LaunchApplication2] = Keys.LaunchApplication2;
            _keysDictionaryWpf[WpfKeys.OemPlus] = Keys.OemPlus;
            _keysDictionaryWpf[WpfKeys.OemComma] = Keys.OemComma;
            _keysDictionaryWpf[WpfKeys.OemMinus] = Keys.OemMinus;
            _keysDictionaryWpf[WpfKeys.OemPeriod] = Keys.OemPeriod;
            _keysDictionaryWpf[WpfKeys.OemQuestion] = Keys.OemQuestion;
            _keysDictionaryWpf[WpfKeys.OemOpenBrackets] = Keys.OemOpenBrackets;
            _keysDictionaryWpf[WpfKeys.OemQuotes] = Keys.OemQuotes;
            _keysDictionaryWpf[WpfKeys.Oem8] = Keys.Oem8;
            _keysDictionaryWpf[WpfKeys.OemBackslash] = Keys.OemBackslash;
            _keysDictionaryWpf[WpfKeys.OemCopy] = Keys.OemCopy;
            _keysDictionaryWpf[WpfKeys.EraseEof] = Keys.EraseEof;
            _keysDictionaryWpf[WpfKeys.Play] = Keys.Play;
            _keysDictionaryWpf[WpfKeys.Pa1] = Keys.Pa1;
            _keysDictionaryWpf[WpfKeys.OemClear] = Keys.OemClear;
        }

        /// <summary>
        /// Creates a new instance of <see cref="KeyboardPlatformDesktopWpf"/> class
        /// </summary>
        /// <param name="nativeWindow">The native window object reference</param>
        /// <exception cref="ArgumentNullException">Is thrown when <paramref name="nativeWindow"/> is null</exception>
        public KeyboardPlatformDesktopWpf(object nativeWindow) : base(nativeWindow)
        {
        }

        /// <summary>
        /// Derived classes should implement platform-specific event bindings in this method
        /// </summary>
        /// <param name="nativeWindow">The native window object reference</param>
        /// <exception cref="ArgumentNullException">Is thrown when <paramref name="nativeWindow"/> is null</exception>
        /// <exception cref="InvalidOperationException">Is thrown when <paramref name="nativeWindow"/> is of an unsupported type.</exception>
        protected override void BindWindow(object nativeWindow)
        {
            var element = nativeWindow as SharpDXElement;
            if (element != null)
            {
                element.PreviewKeyDown += HandlePreviewKeyDown;
                element.KeyDown += HandleKeyDown;
                element.KeyUp += HandleKeyUp;

                return;
            }

            throw new InvalidOperationException(string.Format("Unsupported native window: {0}", nativeWindow));
        }

        /// <summary>
        /// Handles the <see cref="System.Windows.UIElement.PreviewKeyDown"/> event.
        /// </summary>
        /// <param name="sender">Ignored</param>
        /// <param name="e">The key is read from <see cref="System.Windows.Input.KeyEventArgs.Key"/> property.</param>
        private void HandlePreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            ProcessKeyEvent(e.Key, RaiseKeyPressed);
        }

        /// <summary>
        /// Handles the <see cref="System.Windows.UIElement.KeyDown"/> event.
        /// </summary>
        /// <param name="sender">Ignored</param>
        /// <param name="e">The key is read from <see cref="System.Windows.Input.KeyEventArgs.Key"/> property.</param>
        private void HandleKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            e.Handled = true;
            ProcessKeyEvent(e.Key, RaiseKeyPressed);
        }

        /// <summary>
        /// Handles the <see cref="System.Windows.UIElement.KeyUp"/> event.
        /// </summary>
        /// <param name="sender">Ignored</param>
        /// <param name="e">The key is read from <see cref="System.Windows.Input.KeyEventArgs.Key"/> property.</param>
        private void HandleKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            e.Handled = true;
            ProcessKeyEvent(e.Key, RaiseKeyReleased);
        }

        /// <summary>
        /// Translates the WPF key to Toolkit key and invokes status change
        /// </summary>
        /// <remarks>For modifier keys (Shift, Control, Alt) will invoke its Left... analog additionally</remarks>
        /// <param name="keyCode">WPF key code to be translated</param>
        /// <param name="keyAction">delegate to invoke with translated key</param>
        private static void ProcessKeyEvent(WpfKeys keyCode, Action<Keys> keyAction)
        {
            Keys translatedKey;
            if (!_keysDictionaryWpf.TryGetValue(keyCode, out translatedKey))
                translatedKey = Keys.None;

            keyAction(translatedKey);

            // XNA doesn't have handless modifier keys, so we will map general keys to left ones:
            // TODO: consider P/Invoke to get pressed keys and/or determine which key was pressed
            switch (translatedKey)
            {
                case Keys.Shift:
                    keyAction(Keys.LeftShift);
                    break;
                case Keys.Control:
                    keyAction(Keys.LeftControl);
                    break;
                case Keys.Alt:
                    keyAction(Keys.LeftAlt);
                    break;
            }
        }
    }
}

#endif