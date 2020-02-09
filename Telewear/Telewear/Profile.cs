using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms;

namespace Telewear {
    public class Profile : ContentPage {
        async Task<byte[]> DownloadImageAsync(string imageUrl) {
            var _httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(15) };

            try {
                using (var httpResponse = await _httpClient.GetAsync(imageUrl)) {
                    if (httpResponse.StatusCode == HttpStatusCode.OK) {
                        return await httpResponse.Content.ReadAsByteArrayAsync();
                    } else {
                        //Url is Invalid
                        return null;
                    }
                }
            } catch (Exception) {
                //Handle Exception
                return null;
            }
        }
        public Profile(User user) {
            Content = new ScrollView() {
                Content = new StackLayout() {
                    Margin = new Thickness(20,20,20,20),
                    Children = {
                        new StackLayout
                        {
                            Spacing = 0,
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                new Image {
                                    Source = ImageSource.FromUri(new Uri("https://pbs.twimg.com/profile_images/634355445579284481/V3BMUJ9v.jpg"))
                                },
                                new Label {
                                    Text = user.fullName,
                                    FontSize = 15,
                                    FontAttributes = FontAttributes.Bold,
                                    HorizontalTextAlignment = TextAlignment.Center
                                },
                            }
                        },
                        
                        new Label {
                            Text = user.bio,
                            FontSize = 7,
                            FontAttributes = FontAttributes.Italic,
                            HorizontalTextAlignment = TextAlignment.Center
                        },
                        new Label {
                            Text = "bio",
                            FontSize = 6,
                            TextColor = Color.DarkGray,
                            HorizontalTextAlignment = TextAlignment.Center
                        },
                        new Label {
                            Text = user.phone,
                            FontSize = 7,
                            HorizontalTextAlignment = TextAlignment.Center
                        },
                        new Label {
                            Text = "phone number",
                            FontSize = 6,
                            TextColor = Color.DarkGray,
                            HorizontalTextAlignment = TextAlignment.Center
                        },
                    }
                }
            };
        }
    }
}