using Newtonsoft.Json;
using System.Net;
using WeatherApp.Models;

namespace WeatherApp
{
	public partial class WeatherForm : Form
	{
		public WeatherForm()
		{
			InitializeComponent();
		}
		string APIKey = "73e7093443508a22f7a5eeadff124130";

		private void btnSearch_Click(object sender, EventArgs e)
		{
			getWeather();
		}
		void getWeather()
		{
			using (WebClient web = new WebClient())
			{
				string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
				var json = web.DownloadString(url);
				WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

				picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
				labCondition.Text = Info.weather[0].main.ToUpper();
				labDetails.Text = Info.weather[0].description.ToUpper();
				labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();
				labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString ();

				labWindSpeed.Text = Math.Round(Info.wind.speed * 3.6).ToString() + " km/h";
				labPressure.Text = Info.main.pressure.ToString();
				labHumidity.Text = Info.main.humidity.ToString() + "%";
				labTemperature.Text = Math.Round((Info.main.temp - 273)).ToString();
			}
		}

		DateTime convertDateTime(long millisec)
		{
			DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
			day = day.AddSeconds(millisec).ToLocalTime();

			return day;
		}
	}
}
