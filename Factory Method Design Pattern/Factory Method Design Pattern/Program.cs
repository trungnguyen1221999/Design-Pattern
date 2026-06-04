using Factory_Method_Design_Pattern;
var client = new Client();
client.Delivery(new CheapShipping());
client.Delivery(new FastShipping());


client.Delivery(new HeavyProductShipping());