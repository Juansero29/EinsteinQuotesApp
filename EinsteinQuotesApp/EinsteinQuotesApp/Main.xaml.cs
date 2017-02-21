using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EinsteinQuotesApp
{
		public partial class Main : ContentPage
		{
				private int _currentQuote = 0;

				private readonly string[] _einsteinQuotes =
				{
			"Imagination is more important than knowledge.",
			"The important thing is not to stop questioning. Curiosity has its own reason for existing. ",
			"Anyone who has never made a mistake has never tried anything new.",
			"Try not to become a man of success, but rather try to become a man of value.",
			"Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
			"Science without religion is lame, religion without science is blind.",
			"The significant problems we have cannot be solved at the same level of thinking with which we created them.",
			"Everything should be made as simple as possible, but not simpler.",
			"The most beautiful thing we can experience is the mysterious. It is the source of all true art and science.",
			"I have no special talents. I am only passionately curious."
		};


				public Main()
				{
						InitializeComponent();
						QuoteLabel.Text = _einsteinQuotes[_currentQuote];
				}

				private void Button_OnClicked(object sender, EventArgs e)
				{
						if (_currentQuote < _einsteinQuotes.Length - 1)
						{
								_currentQuote += 1;
						}
						else
						{
								_currentQuote = 0;
						}
						QuoteLabel.Text = _einsteinQuotes[_currentQuote];
				}
		}
}
