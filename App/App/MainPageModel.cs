using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace App
{
    public class MainPageModel : ObservableObject
    {
        public ObservableCollection<ItemViewModel> Items { get; set; } = [];

        public MainPageModel()
        {
            Items.Add(CreateWhiteCard("1"));
            Items.Add(CreateGrayCard("2"));
            Items.Add(CreateWhiteCard("3"));
            Items.Add(CreateGrayCard("4"));
            Items.Add(CreateWhiteCard("5"));
            Items.Add(CreateGrayCard("6"));
            Items.Add(CreateWhiteCard("7"));
            Items.Add(CreateGrayCard("8"));
            Items.Add(CreateWhiteCard("9"));
            Items.Add(CreateGrayCard("10"));
            Items.Add(CreateWhiteCard("11"));
            Items.Add(CreateGrayCard("12"));
            Items.Add(CreateWhiteCard("13"));
            Items.Add(CreateGrayCard("14"));
            Items.Add(CreateWhiteCard("15"));
            Items.Add(CreateGrayCard("16"));
            Items.Add(CreateWhiteCard("17"));
            Items.Add(CreateGrayCard("18"));
            Items.Add(CreateWhiteCard("19"));
            Items.Add(CreateGrayCard("20"));
            Items.Add(CreateWhiteCard("21"));
            Items.Add(CreateGrayCard("22"));
            Items.Add(CreateWhiteCard("23"));
            Items.Add(CreateGrayCard("24"));
            Items.Add(CreateWhiteCard("25"));
            Items.Add(CreateGrayCard("26"));
            Items.Add(CreateWhiteCard("27"));
            Items.Add(CreateGrayCard("28"));
            Items.Add(CreateWhiteCard("29"));
            Items.Add(CreateWhiteCard("30"));
            Items.Add(CreateWhiteCard("31"));
            Items.Add(CreateWhiteCard("32"));
            Items.Add(CreateWhiteCard("33"));
            Items.Add(CreateWhiteCard("34"));
            Items.Add(CreateWhiteCard("35"));
            Items.Add(CreateWhiteCard("36"));
            Items.Add(CreateWhiteCard("37"));
            Items.Add(CreateWhiteCard("38"));
            Items.Add(CreateWhiteCard("39"));
            Items.Add(CreateWhiteCard("40"));
            Items.Add(CreateWhiteCard("41"));
            Items.Add(CreateWhiteCard("42"));
            Items.Add(CreateWhiteCard("43"));
            Items.Add(CreateWhiteCard("44"));
            Items.Add(CreateWhiteCard("45"));
            Items.Add(CreateWhiteCard("46"));
            Items.Add(CreateWhiteCard("47"));
            Items.Add(CreateWhiteCard("48"));
            Items.Add(CreateWhiteCard("49"));
            Items.Add(CreateWhiteCard("50"));
            Items.Add(CreateWhiteCard("51"));
            Items.Add(CreateWhiteCard("52"));
            Items.Add(CreateWhiteCard("53"));
            Items.Add(CreateWhiteCard("54"));
            Items.Add(CreateWhiteCard("55"));
            Items.Add(CreateWhiteCard("56"));
            Items.Add(CreateWhiteCard("57"));
            Items.Add(CreateWhiteCard("58"));
            Items.Add(CreateWhiteCard("59"));
            Items.Add(CreateGrayCard("60"));
            Items.Add(CreateGrayCard("61"));
            Items.Add(CreateGrayCard("62"));
            Items.Add(CreateGrayCard("63"));
            Items.Add(CreateGrayCard("64"));
            Items.Add(CreateGrayCard("65"));
            Items.Add(CreateGrayCard("66"));
            Items.Add(CreateGrayCard("67"));
            Items.Add(CreateGrayCard("68"));
            Items.Add(CreateGrayCard("69"));
            Items.Add(CreateGrayCard("70"));
            Items.Add(CreateGrayCard("71"));
            Items.Add(CreateGrayCard("72"));
            Items.Add(CreateGrayCard("73"));
            Items.Add(CreateGrayCard("74"));
            Items.Add(CreateGrayCard("75"));
            Items.Add(CreateGrayCard("76"));
            Items.Add(CreateGrayCard("77"));
            Items.Add(CreateGrayCard("78"));
            Items.Add(CreateGrayCard("79"));
            Items.Add(CreateGrayCard("80"));
            Items.Add(CreateGrayCard("81"));
            Items.Add(CreateGrayCard("82"));
            Items.Add(CreateGrayCard("83"));
            Items.Add(CreateGrayCard("84"));
            Items.Add(CreateGrayCard("85"));
            Items.Add(CreateGrayCard("86"));
            Items.Add(CreateGrayCard("87"));
            Items.Add(CreateGrayCard("88"));
            Items.Add(CreateGrayCard("89"));
            Items.Add(CreateGrayCard("90"));
            Items.Add(CreateGrayCard("91"));
            Items.Add(CreateGrayCard("92"));
            Items.Add(CreateGrayCard("93"));
            Items.Add(CreateGrayCard("94"));
            Items.Add(CreateGrayCard("95"));
            Items.Add(CreateGrayCard("96"));
            Items.Add(CreateGrayCard("97"));
            Items.Add(CreateGrayCard("98"));
            Items.Add(CreateGrayCard("99"));
        }

        private ItemViewModel CreateWhiteCard(string text)
        {
            return new ItemViewModel
            {
                Text = text,
                CardBackgroundColor = Colors.White,
                CardBorderColor = Colors.Black,
                CardBorderDash = new DoubleCollection()
            };
        }

        private ItemViewModel CreateGrayCard(string text)
        {
            return new ItemViewModel
            {
                Text = text,
                CardBackgroundColor = Colors.LightGray,
                CardBorderColor = Colors.DarkGray,
                CardBorderDash = new DoubleCollection([3, 3])
            };
        }
    }
}
