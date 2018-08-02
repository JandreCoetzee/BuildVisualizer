using System;
using System.Threading;
using Corale.Colore.Core;
using Corale.Colore.Razer.Effects;
using Corale.Colore.Razer.Keyboard;
using Corale.Colore.Razer.Keyboard.Effects;
using ColoreColor = Corale.Colore.Core.Color;
using KeyboardCustom = Corale.Colore.Razer.Keyboard.Effects.Custom;

namespace Razer
{
    public class ChromaEvent
    {
        public void Pulse(object sender, EventArgs e)
        {
            //Chroma.Instance.SetAll(ColoreColor.Red);

            //var customEffect = new Corale.Colore.Razer.Keyboard.Effects.Custom(Color.Green);

            // Chroma.Instance.Keyboard.SetCustom(customEffect);

            //Chroma.Instance.Keyboard.SetKey(Key.A, ColoreColor.Blue);


            // Create a Random Generator
            //Random random = new Random();
            //// Create the custom Grid
            //var keyboardGrid = KeyboardCustom.Create();

            //// Loop through all Rows
            //for (var r = 0; r < Constants.MaxRows; r++)
            //{
            //    //Loop through all Columns
            //    for (var c = 0; c < Constants.MaxColumns; c++)
            //    {
            //        // Set the current row and column to the random color
            //        keyboardGrid[r, c] = new ColoreColor(random.Next(256), random.Next(256), random.Next(256));
            //    }
            //}

            //Chroma.Instance.Keyboard.SetCustom(keyboardGrid);


            Random random = new Random();
            var keyboardGrid = KeyboardCustom.Create();
            var sleepTime = 50;

            for (var r = 0; r < Constants.MaxRows; r++)
            {
                if (r % 2 == 0)
                {
                    for (int c = 0; c < Constants.MaxColumns; c++)
                    {
                        keyboardGrid[r, c] = ColoreColor.White;
                        //keyboardGrid[r, c] = new ColoreColor(random.Next(256), random.Next(256), random.Next(256));
                        Chroma.Instance.Keyboard.SetCustom(keyboardGrid);
                        Thread.Sleep(sleepTime);
                    }
                }
                else
                {
                    for (int c = Constants.MaxColumns - 1; c >= 0; c--)
                    {
                        keyboardGrid[r, c] = ColoreColor.Blue;
                        Chroma.Instance.Keyboard.SetCustom(keyboardGrid);
                        Thread.Sleep(sleepTime);
                    }
                }
            }

            Chroma.Instance.SetAll(ColoreColor.Green);
            Thread.Sleep(1000);
            Chroma.Instance.SetAll(ColoreColor.Red);
            Thread.Sleep(1000);
            Chroma.Instance.SetAll(ColoreColor.Black);

            for (var r = 0; r < Constants.MaxRows; r++)
            {
                if (r % 2 != 0)
                {
                    for (int c = 0; c < Constants.MaxColumns; c++)
                    {
                        keyboardGrid[r, c] = ColoreColor.White;
                        //keyboardGrid[r, c] = new ColoreColor(random.Next(256), random.Next(256), random.Next(256));
                        Chroma.Instance.Keyboard.SetCustom(keyboardGrid);
                        Thread.Sleep(sleepTime);
                    }
                }
                else
                {
                    for (int c = Constants.MaxColumns - 1; c >= 0; c--)
                    {
                        keyboardGrid[r, c] = ColoreColor.Blue;
                        Chroma.Instance.Keyboard.SetCustom(keyboardGrid);
                        Thread.Sleep(sleepTime);
                    }
                }
            }
            Chroma.Instance.SetAll(ColoreColor.Black);
        }
    }
}