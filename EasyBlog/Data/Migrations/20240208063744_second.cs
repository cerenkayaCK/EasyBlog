using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyBlog.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "The future of technology is incredibly exciting, promising to bring new innovations that will revolutionize the way we live, work, and interact. From artificial intelligence and quantum computing to augmented reality and beyond, the possibilities are endless.</p><p>As we navigate this ever-evolving landscape, it's clear that technology will continue to play a pivotal role in shaping our future. The potential for positive change is immense, making this an exhilarating time to be alive and witness the advancements firsthand.");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "In today's fast-paced world, staying up-to-date with the latest technology gadgets can be a challenge. From the newest smartphones and smartwatches to drones and virtual reality headsets, the array of options is vast.</p><p>This review aims to shed light on some of the most groundbreaking gadgets currently on the market. By exploring their features, benefits, and potential drawbacks, we hope to provide valuable insights that will help you make informed decisions.");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Maintaining a healthy lifestyle is crucial for overall well-being. It encompasses a variety of aspects, including balanced nutrition, regular exercise, adequate sleep, and stress management. Adopting these practices can lead to significant improvements in health and happiness.</p><p>In this article, we'll explore practical tips and strategies for living a healthier life. Whether you're looking to overhaul your diet, incorporate more physical activity into your routine, or find effective ways to relax and de-stress, we've got you covered.");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "Transforming your living space into a personalized oasis doesn't have to break the bank. With a little creativity and some DIY spirit, you can create beautiful, unique decorations that reflect your style and personality.</p><p>In this guide, we'll share some innovative DIY home decor ideas that are both easy and affordable. From upcycled furniture to handmade wall art, these projects will inspire you to get creative and make your home truly your own.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "<p>The future of technology is incredibly exciting, promising to bring new innovations that will revolutionize the way we live, work, and interact. From artificial intelligence and quantum computing to augmented reality and beyond, the possibilities are endless.</p><p>As we navigate this ever-evolving landscape, it's clear that technology will continue to play a pivotal role in shaping our future. The potential for positive change is immense, making this an exhilarating time to be alive and witness the advancements firsthand.</p>");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "<p>In today's fast-paced world, staying up-to-date with the latest technology gadgets can be a challenge. From the newest smartphones and smartwatches to drones and virtual reality headsets, the array of options is vast.</p><p>This review aims to shed light on some of the most groundbreaking gadgets currently on the market. By exploring their features, benefits, and potential drawbacks, we hope to provide valuable insights that will help you make informed decisions.</p>");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "<p>Maintaining a healthy lifestyle is crucial for overall well-being. It encompasses a variety of aspects, including balanced nutrition, regular exercise, adequate sleep, and stress management. Adopting these practices can lead to significant improvements in health and happiness.</p><p>In this article, we'll explore practical tips and strategies for living a healthier life. Whether you're looking to overhaul your diet, incorporate more physical activity into your routine, or find effective ways to relax and de-stress, we've got you covered.</p>");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: "<p>Transforming your living space into a personalized oasis doesn't have to break the bank. With a little creativity and some DIY spirit, you can create beautiful, unique decorations that reflect your style and personality.</p><p>In this guide, we'll share some innovative DIY home decor ideas that are both easy and affordable. From upcycled furniture to handmade wall art, these projects will inspire you to get creative and make your home truly your own.</p>");
        }
    }
}
