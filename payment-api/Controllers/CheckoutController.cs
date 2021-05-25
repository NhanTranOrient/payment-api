using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using payment_api.Domain.Entities;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace payment_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        public CheckoutController()
        {

        }

        [HttpPost]
        public CheckoutSession Checkout(Product product)
        {
            var UIdomain = "http://localhost:3000";
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                  "card",
                },
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                      UnitAmount = (long?)(product.Price*100),
                      Currency = "usd",
                      ProductData = new SessionLineItemPriceDataProductDataOptions
                      {
                        Name = product.Name,
                      },
                    },
                    Quantity = 1,
                  },
                },
                Mode = "payment",
                SuccessUrl = UIdomain + "/checkout/success",
                CancelUrl = UIdomain + "/checkout/error",
            };
            var service = new SessionService();
            Session session = service.Create(options);
            return new CheckoutSession { Id = session.Id };
        }
    }
}
