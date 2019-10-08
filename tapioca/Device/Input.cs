﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace tapioca.Device
{
    static class Input
    {
        //移動量
        private static Vector2 velocity = Vector2.Zero;
        //キーボード
        private static KeyboardState currentKey;
        private static KeyboardState previousKey;
        //マウス
        private static MouseState currentMouse;
        private static MouseState previusMouse;

        public static void Update()
        {
            //キーボード
            previousKey = currentKey;
            currentKey = Keyboard.GetState();
            //マウス
            previusMouse = currentMouse;
            currentMouse = Mouse.GetState();

            UpdateVelocity();
        }

        //キーボード関連
        public static Vector2 Velocity()
        {
            return velocity;
        }
        private static void UpdateVelocity()
        {
            //毎ループ初期化
            velocity = Vector2.Zero;

            //右
            if (currentKey.IsKeyDown(Keys.Right))
            {
                velocity.X += 1.0f;
            }
            //左
            if (currentKey.IsKeyDown(Keys.Left))
            {
                velocity.X -= 1.0f;
            }
            //上
            if (currentKey.IsKeyDown(Keys.Up))
            {
                velocity.Y = -1.0f;
            }
            //下
            if (currentKey.IsKeyDown(Keys.Down))
            {
                velocity.Y += 1.0f;
            }

            //正規化
            if (velocity.Length() != 0)
            {
                velocity.Normalize();
            }
        }
        ///<summary>キーが押された瞬間か？</summary>
        ///<param name="Key">チェックしたいキー</param>
        ///<returns>現在キーが押されていて1フレーム前に押されていなければtrue</returns>
        public static bool IsKeyDown(Keys key)
        {
            return currentKey.IsKeyDown(key) && !previousKey.IsKeyDown(key);
        }

        ///<summary>キーが押された瞬間か？</summary>
        ///<param name="Key">チェックしたいキー</param>
        ///<returns>押された瞬間ならtrue</returns>
        public static bool GetKeyTrigger(Keys key)
        {
            return IsKeyDown(key);
        }
        ///<summary>キーが押されているか</summary>
        ///<param name="Key">調べたいキー</param>
        ///<returns>キーが押されていたら</returns>
        public static bool GetKeyState(Keys key)
        {
            return currentKey.IsKeyDown(key);
        }
        //マウス関連
        ///<summary>マウスの左ボタンが押された瞬間か</summary>
        ///<returns>現在押されていて1フレーム前に押されていなければtrue</returns>
        public static bool IsMouseLBottonDown()
        {
            return currentMouse.LeftButton == ButtonState.Pressed && previusMouse.LeftButton == ButtonState.Released;
        }
        ///<summary>マウスの左ボタンが押された瞬間か</summary>
        ///<returns>現在押されていて1フレーム前に押されていたらtrue</returns>
        public static bool IsMouseLBootonUp()
        {
            return currentMouse.LeftButton == ButtonState.Released && previusMouse.LeftButton == ButtonState.Pressed;
        }
        ///<summary>マウスの左ボタンが押されているか</summary>
        ///<returns>左ボタンが押されていたらtrue</returns>
        public static bool IsMouseLButton()
        {
            return currentMouse.LeftButton == ButtonState.Pressed;
        }

        ///<summary>マウスの右ボタンが押された瞬間か</summary>
        ///<returns>現在押されていて1フレーム前に押されていなければtrue</returns>
        public static bool IsMouseRBottonDown()
        {
            return currentMouse.RightButton == ButtonState.Pressed && previusMouse.RightButton == ButtonState.Released;
        }
        ///<summary>マウスの右ボタンが押された瞬間か</summary>
        ///<returns>現在押されていて1フレーム前に押されていたらtrue</returns>
        public static bool IsMouseRBootonUp()
        {
            return currentMouse.RightButton == ButtonState.Released && previusMouse.RightButton == ButtonState.Pressed;
        }
        ///<summary>マウスの右ボタンが押されているか</summary>
        ///<returns>右ボタンが押されていたらtrue</returns>
        public static bool IsMouseRButton()
        {
            return currentMouse.RightButton == ButtonState.Pressed;
        }

        ///<summary>マウスの位置を返す</summary>
        public static Vector2 MousePosition
        {
            //プロパティでGetterを作成
            get
            {
                return new Vector2(currentMouse.X, currentMouse.Y);
            }
        }
        ///<summary>マウスのスクロールホイールの変化量</summary>
        ///<returns>1フレーム前と現在のホイール量の差分</returns>
        public static int GetMouseWheel()
        {
            return previusMouse.ScrollWheelValue - currentMouse.ScrollWheelValue;
        }
    }
}
