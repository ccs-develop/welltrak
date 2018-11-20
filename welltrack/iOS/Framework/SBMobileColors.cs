//using System;
//using UIKit;
//using CoreGraphics;
////using SmartBen.Api.Model.Enums;

//namespace welltrak.iOS
//{
//	public class SBMobileColors
//	{
//		public UIColor ForestGreen = new UIColor(red: 0.10f, green: 0.74f, blue: 0.61f, alpha: 1.0f);
//		public UIColor DarkForestGreen = new UIColor(red: 0.09f, green: 0.63f, blue: 0.52f, alpha: 1.0f);
//		public UIColor BaseBlue = new UIColor(red: 0.10f, green: 0.61f, blue: 0.86f, alpha: 1.0f);
//		public UIColor DarkBaseBlue = new UIColor(red: 0.09f, green: 0.54f, blue: 0.76f, alpha: 1.0f);
//		public UIColor Purple = new UIColor(red: 0.44f, green: 0.32f, blue: 0.51f, alpha: 1.0f);
//		public UIColor DarkPurple = new UIColor(red: 0.36f, green: 0.26f, blue: 0.41f, alpha: 1.0f);
//	    public UIColor Orange = new UIColor(red: 0.94f, green: 0.40f, blue: 0.15f, alpha: 1.0f);
//	    public UIColor DarkOrange = new UIColor(red: 0.63f, green: 0.27f, blue: 0.09f, alpha: 1.0f);
//        public UIColor LightOrange = new UIColor(red: 1.00f, green: 0.86f, blue: 0.53f, alpha: 1.0f);
//		public UIColor Red = new UIColor(red: 0.86f, green: 0.23f, blue: 0.16f, alpha: 1.0f);
//		public UIColor DarkRed = new UIColor(red: 0.76f, green: 0.21f, blue: 0.15f, alpha: 1.0f);
//		public UIColor Clouds = new UIColor(red: 0.95f, green: 0.95f, blue: 0.95f, alpha: 1.0f);
//		public UIColor BaseGreen = new UIColor(red: 0.42f, green: 0.78f, blue: 0.15f, alpha: 1.0f);
//		public UIColor DarkBaseGreen = new UIColor(red: 0.37f, green: 0.68f, blue: 0.14f, alpha: 1.0f);
//		public UIColor MidnightBlue = new UIColor(red: 0.00f, green: 0.09f, blue: 0.25f, alpha: 1.0f);
//		public UIColor WetAsphault = new UIColor(red: 0.20f, green: 0.29f, blue: 0.37f, alpha: 1.0f);
//		public UIColor LightGrey = new UIColor(red: 0.55f, green: 0.55f, blue: 0.56f, alpha: 1.0f);
//		public UIColor DarkGrey = new UIColor(red: 0.35f, green: 0.36f, blue: 0.36f, alpha: 1.0f);
//		public UIColor TrueWhite = new UIColor(red: 0.98f, green: 0.98f, blue: 0.98f, alpha: 1.0f);
//		public UIColor TrueBlack = new UIColor(red: 0.16f, green: 0.16f, blue: 0.16f, alpha: 1.0f);
//		public UIColor Carrot = new UIColor(red: 0.90f, green: 0.49f, blue: 0.13f, alpha: 1.0f);
//		public UIColor Asbestos = new UIColor(red: 0.50f, green: 0.55f, blue: 0.55f, alpha: 1.0f);
//        public UIColor Grey = new UIColor(red: 0.8f, green: 0.8f, blue: 0.8f, alpha: 1.0f);

//		internal UIColor GetColor(Colors colorValue)
//		{
//			switch (colorValue)
//			{
//				case Colors.BaseBlue: { return BaseBlue; }
//				case Colors.DarkBaseBlue: { return DarkBaseBlue; }
//				case Colors.Purple: { return Purple; }
//				case Colors.DarkPurple: { return DarkPurple; }
//				case Colors.DarkForestGreen: { return DarkForestGreen; }
//				case Colors.ForestGreen: { return ForestGreen; }
//				case Colors.DarkBaseGreen: { return DarkBaseGreen; }
//				case Colors.BaseGreen: { return BaseGreen; }
//				case Colors.TrueBlack: { return TrueBlack; }
//				case Colors.Clouds: { return Clouds; }
//				case Colors.MidnightBlue: { return MidnightBlue; }
//				case Colors.WetAsphault: { return WetAsphault; }
//				case Colors.LightOrange: { return LightOrange; }
//				case Colors.Orange: { return Orange; }
//				case Colors.DarkOrange: { return DarkOrange; }
//				case Colors.DarkRed: { return DarkRed; }
//				case Colors.Red: { return Red; }
//				case Colors.LightGrey: { return LightGrey; }
//				case Colors.TrueWhite: { return TrueWhite; }
//				case Colors.Carrot: { return Carrot; }
//				case Colors.Asbestos: { return Asbestos; }
//                case Colors.Grey: { return Grey; }
//			    default: { return null; }
//			};
//		}

//		public UIColor ConvertFromString(string colorString)
//		{
//			var color = GetColor((Colors)Enum.Parse(typeof(Colors), colorString));
//			if (color != null)
//			{
//				return color;
//			}
//			else
//			{
//				//if something goes wrong, return clear as the color.
//				return UIColor.Clear;
//			}
//		}
//	}

//}
