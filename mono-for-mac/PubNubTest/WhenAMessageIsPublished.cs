using System;
using PubNubMessaging.Core;
using NUnit.Framework;
using System.ComponentModel;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Net.Sockets;

namespace PubNubMessaging.Tests
{
    [TestFixture]
    public class WhenAMessageIsPublished
    {
        public void NullMessage()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                                "",
                                "",
                                false
                            );
            string channel = "hello_world";
            string message = null;

            Common common = new Common();
            common.DeliveryStatus = false;
            common.Response = null;

            pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    string one = fields [0].ToString();
                    Assert.AreEqual("Sent", sent);
                    Assert.AreEqual("1", one);
                } else
                {
                    Assert.Fail("Null response");
                }
        }

        [Test]
        public void ThenItShouldReturnSuccessCodeAndInfoForEncryptedComplexMessage2()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                              "",
                              "enigma",
                              false
                          );
            string channel = "hello_world";
            object message = new PubnubDemoObject();
          
            Common common = new Common();
          
            pubnub.PubnubUnitTest = common.CreateUnitTestInstance("WhenAMessageIsPublished", "ThenItShouldReturnSuccessCodeAndInfoForEncryptedComplexMessage2");
          
            common.DeliveryStatus = false;
            common.Response = null;
          
            pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    string one = fields [0].ToString();
                    Assert.AreEqual("Sent", sent);
                    Assert.AreEqual("1", one);
                } else
                {
                    Assert.Fail("Null response");
                }
        }

        [Test]
        public void ThenItShouldReturnSuccessCodeAndInfoForComplexMessage2WithSsl()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                              "",
                              "",
                              true
                          );
            string channel = "hello_world";
            object message = new PubnubDemoObject();
            //object message = new CustomClass2();
          
            string json = Common.Serialize(message);
            Common common = new Common();
          
            pubnub.PubnubUnitTest = common.CreateUnitTestInstance("WhenAMessageIsPublished", "ThenItShouldReturnSuccessCodeAndInfoForComplexMessage2WithSsl");
          
            common.DeliveryStatus = false;
            common.Response = null;
          
            pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    string one = fields [0].ToString();
                    Assert.AreEqual("Sent", sent);
                    Assert.AreEqual("1", one);
                } else
                {
                    Assert.Fail("Null response");
                }
        }

        [Test]
        public void ThenItShouldReturnSuccessCodeAndInfoForComplexMessage2()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                                "",
                                "",
                                false
                            );
            string channel = "test";
            object message = new PubnubDemoObject();
            //object message = new CustomClass2();

            string json = Common.Serialize(message);
            Common common = new Common();

            pubnub.PubnubUnitTest = common.CreateUnitTestInstance("WhenAMessageIsPublished", "ThenItShouldReturnSuccessCodeAndInfoForComplexMessage2");

            common.DeliveryStatus = false;
            common.Response = null;

            pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    string one = fields [0].ToString();
                    Assert.AreEqual("Sent", sent);
                    Assert.AreEqual("1", one);
                } else
                {
                    Assert.Fail("Null response");
                }
        }

        [Test]
        public void ThenItShouldReturnSuccessCodeAndInfoForComplexMessage()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                              "",
                              "",
                              false
                          );
            string channel = "hello_world";
            object message = new CustomClass();
          
            Common common = new Common();
          
            pubnub.PubnubUnitTest = common.CreateUnitTestInstance("WhenAMessageIsPublished", "ThenItShouldReturnSuccessCodeAndInfoForComplexMessage");
          
            common.DeliveryStatus = false;
            common.Response = null;
          
            pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    string one = fields [0].ToString();
                    Assert.AreEqual("Sent", sent);
                    Assert.AreEqual("1", one);
                } else
                {
                    Assert.Fail("Null response");
                }
        }

        [Test]
        public void ThenItShouldReturnSuccessCodeAndInfoWhenEncrypted()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                              "",
                              "enigma",
                              false
                          );
            string channel = "hello_world";
            string message = "Pubnub API Usage Example";
          
            Common common = new Common();
          
            pubnub.PubnubUnitTest = common.CreateUnitTestInstance("WhenAMessageIsPublished", "ThenItShouldReturnSuccessCodeAndInfoWhenEncrypted");
          
            common.DeliveryStatus = false;
            common.Response = null;
          
            pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    Console.WriteLine(common.Response.ToString());
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    string one = fields [0].ToString();
                    Assert.AreEqual("Sent", sent);
                    Assert.AreEqual("1", one);
                } else
                {
                    Assert.Fail("Null response");
                }
        }

        [Test]
        public void ThenItShouldReturnSuccessCodeAndInfoWhenEncryptedAndSecretKeyed()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                              "secret",
                              "enigma",
                              false
                          );
            string channel = "hello_world";
            string message = "Pubnub API Usage Example";
          
            Common common = new Common();
          
            pubnub.PubnubUnitTest = common.CreateUnitTestInstance("WhenAMessageIsPublished", "ThenItShouldReturnSuccessCodeAndInfoWhenEncryptedAndSecretKeyed");
          
            common.DeliveryStatus = false;
            common.Response = null;
          
            pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    Console.WriteLine(common.Response.ToString());
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    string one = fields [0].ToString();
                    Assert.AreEqual("Sent", sent);
                    Assert.AreEqual("1", one);
                } else
                {
                    Assert.Fail("Null response");
                }
        }

        [Test]
        public void ThenItShouldReturnSuccessCodeAndInfo()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                                "",
                                "",
                                false
                            );
            string channel = "hello_world";
            string message = "Pubnub API Usage Example";

            Common common = new Common();
            
            pubnub.PubnubUnitTest = common.CreateUnitTestInstance("WhenAMessageIsPublished", "ThenItShouldReturnSuccessCodeAndInfo");

            common.DeliveryStatus = false;
            common.Response = null;

            pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    string one = fields [0].ToString();
                    Assert.AreEqual("Sent", sent);
                    Assert.AreEqual("1", one);
                } else
                {
                    Assert.Fail("Null response");
                }
        }

        [Test]
        public void ThenItShouldGenerateUniqueIdentifier()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                                "",
                                "",
                                false
                            );

            Assert.IsNotNull(pubnub.GenerateGuid());
        }

        [Test]
        public void ThenPublishKeyShouldBeOverriden()
        {
            Pubnub pubnub = new Pubnub(
                                "",
                                "demo",
                                "",
                                "",
                                false
                            );
            string channel = "mychannel";
            string message = "Pubnub API Usage Example";

            pubnub = new Pubnub(
                "demo",
                "demo",
                "",
                "",
                false
            );
            Common common = new Common();
            Assert.AreEqual(true, pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage));
        }

        [Test]
        [ExpectedException(typeof(MissingFieldException))]
        public void ThenPublishKeyShouldNotBeEmptyAfterOverriden()
        {
            Pubnub pubnub = new Pubnub(
                                "",
                                "demo",
                                "",
                                "",
                                false
                            );
            string channel = "mychannel";
            string message = "Pubnub API Usage Example";
            Common common = new Common();
            Assert.AreEqual(false, pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage));
        }

        [Test]
        public void ThenSecretKeyShouldBeProvidedOptionally()
        {
            Pubnub pubnub = new Pubnub(
                                "demo",
                                "demo"
                            );
            string channel = "mychannel";
            string message = "Pubnub API Usage Example";
            Common common = new Common();
            Assert.AreEqual(true, pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage));
            pubnub = new Pubnub(
                "demo",
                "demo",
                "key"
            );
            Assert.AreEqual(true, pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage));
        }

        [Test]
        public void IfSSLNotProvidedThenDefaultShouldBeFalse()
        {
            Pubnub pubnub = new Pubnub(
                                "demo",
                                "demo",
                                ""
                            );
            string channel = "hello_world";
            string message = "Pubnub API Usage Example";
            Common common = new Common();
            Assert.AreEqual(true, pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage));
        }

        [Test]
        [ExpectedException(typeof(MissingFieldException))]
        public void NullShouldBeTreatedAsEmpty()
        {
            Pubnub pubnub = new Pubnub(
                                null,
                                "demo",
                                null,
                                null,
                                false
                            );
            string channel = "mychannel";
            string message = "Pubnub API Usage Example";
            Common common = new Common();
            Assert.AreEqual(false, pubnub.Publish(channel, message, common.DisplayReturnMessage, common.DisplayReturnMessage));
        }

        //[Test]
        public void ThenLargeMessageShoudFailWithMessageTooLargeInfo()
        {
            Pubnub pubnub = new Pubnub(
                Common.PublishKey,
                Common.SubscribeKey,
                                "",
                                "",
                                false
                            );
            string channel = "hello_world";
            string messageLarge2K = "This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. This is a large message test which will return an error message. ";
            
            Common common = new Common();
            
            pubnub.PubnubUnitTest = common.CreateUnitTestInstance("WhenAMessageIsPublished", "ThenLargeMessageShoudFailWithMessageTooLargeInfo");
            
            common.DeliveryStatus = false;
            common.Response = null;
            
            pubnub.Publish(channel, messageLarge2K, common.DisplayReturnMessage, common.DisplayReturnMessage);
            //wait till the response is received from the server
            common.WaitForResponse();
            if (common.Response != null)
                {
                    IList<object> fields = common.Response as IList<object>;
                    string sent = fields [1].ToString();
                    Assert.AreEqual("Message Too Large", sent);
                } else
                {
                    Assert.Fail("Null response");
                }
        }
    }
}

