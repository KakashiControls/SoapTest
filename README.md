# WebAPI-2023
SOAP Test



POSTMAN POST METHODE :

https://localhost:7011/Service.asmx

BODY (XML) :

<?xml version="1.0" encoding="utf-8"?>
<soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">
  <soap:Body>
    <Test xmlns="http://tempuri.org/">
      <s>This is a test</s>
    </Test>
  </soap:Body>
</soap:Envelope>
