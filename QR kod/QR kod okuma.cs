OpenFileDialog ofd = new OpenFileDialog();
ofd.ShowDialog();
pictureBox1.ImageLocation = ofd.FileName;
await Task.Delay(500);
var reader = new BarcodeReader();
var result = reader.Decode((Bitmap)pictureBox1.Image);

if (result != null)
{
    textBox1.Text = ("QR Kodun Açıklaması: " + result.Text);
}
else
{
    textBox1.Text = ("QR kodu algılanmadı.");
}