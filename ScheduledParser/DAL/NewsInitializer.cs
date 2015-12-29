using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ScheduledParser.DAL
{
    public class NewsInitializer : DropCreateDatabaseIfModelChanges<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {

            var images = new List<NewsImage>
            {
                new NewsImage()
                {
                    Id = Guid.NewGuid(),
                    ImageTitle = "Image Title",
                    Content = GetBitmapData(new Pen(Color.Red))
                }
            };

            images.ForEach(i  => context.Images.Add(i));
            context.SaveChanges();

            var news = new List<NewsItem>
            {
                new NewsItem
                {
                    Id = Guid.NewGuid(),
                    Content = "Content1",
                    Date = DateTime.Now,
                    ImageUrl = "ImageUrl",
                    OwnerTitle = "Owner Title",
                    Title = "New Title",
                    Url = "Url",
                    Images = images
                }
            };
            news.ForEach(n => context.NewsItems.Add(n));
            context.SaveChanges();
        }

        private byte[] GetBitmapData(Pen penColor)
        {
            //Create the empty image.
            Bitmap image = new Bitmap(50, 50);

            //draw a useless line for some data
            Graphics imageData = Graphics.FromImage(image);
            imageData.DrawLine(penColor, 0, 0, 50, 50);

            //Convert to byte array
            MemoryStream memoryStream = new MemoryStream();
            byte[] bitmapData;

            using (memoryStream)
            {
                image.Save(memoryStream, ImageFormat.Bmp);
                bitmapData = memoryStream.ToArray();
            }
            return bitmapData;
        }
    }


}