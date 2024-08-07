using MangoShop.Domain.Entities;
using NUnit.Framework;

namespace MangoShop.Tests.ModelValidators;



[TestFixture]
public class WhatsAppMessageAttributeTest
{

    [Test]
    public void Phone_Set_Get_ReturnsCorrectVatlue()
    {

        //Arrage
        ///Simulamos un registro de WhatsAppMessage
        var newWhatsAppMessage = new WhatsAppMessage
        {
            PhoneFrom = "123456789",
            PhoneId = "123456789",
            PhoneTo = "123456789",
            MessageBody = "Hola Mundo",
            TemplanteNameUsed = "Template1",
            Created = DateTime.UtcNow
        };

        var expectedPhoneFrom = "123456789";

        //Act
        var actualPhoneFrom = newWhatsAppMessage.PhoneFrom;


        //Assert
        Assert.AreEqual(expectedPhoneFrom, actualPhoneFrom);
    }


    [Test]
    public void TemplateNamdeUsed_ShouldNotBeNullOrEmpty()
    {
        //Arrage
        ///Simulamos un registro de WhatsAppMessage
        var newWhatsAppMessage = new WhatsAppMessage
        {
            PhoneFrom = "123456789",
            PhoneId = "123456789",
            PhoneTo = "123456789",
            MessageBody = "Hola Mundo",
            TemplanteNameUsed = "Template1",
            Created = DateTime.UtcNow
        };

        //Act
        var actualTemplateNamdeUsed = newWhatsAppMessage.TemplanteNameUsed;

        //Assert
        Assert.IsNotNull(actualTemplateNamdeUsed);
    }

}