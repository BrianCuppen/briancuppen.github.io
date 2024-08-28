using MailKit.Net.Smtp;
using MimeKit;
using Microsoft.Extensions.Configuration;

public class EmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    string orderConfirmationTemplate = @"
  <h1>Order Confirmation</h1>
  <p>Thank you for your order, {0}!</p>
  <p>Your order ID is: {1}</p>
  <p>We will notify you once your order is shipped.</p>
";


    public void SendOrderConfirmationEmail(string toEmail, string customerName, string orderId)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Webstore", "noreply@webstore.com"));
        message.To.Add(new MailboxAddress(customerName, toEmail));
        message.Subject = "Order Confirmation [$orderId]";

        var body = string.Format(orderConfirmationTemplate, customerName, orderId);
        message.Body = new TextPart("html") { Text = body };

        using (var client = new SmtpClient())
        {
            client.Connect(_configuration["Smtp:Host"], int.Parse(_configuration["Smtp:Port"]), true);
            client.Authenticate(_configuration["Smtp:Username"], _configuration["Smtp:Password"]);
            client.Send(message);
            client.Disconnect(true);
        }
    }

