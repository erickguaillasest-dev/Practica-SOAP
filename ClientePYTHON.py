from zeep import Client

#Crear el cliente
cliente = Client('http://localhost:65039/Service.svc?wsdl')

#1 Login
if cliente.service.Login("Morales","Morrales2020"):
  print("credenciales correctas")

else:
 print("Credenciales incorrectas")

 #proceesarr pago
 if cliente.service.procesarPago(5000,100)>0:
   print("Pago realizado")
 else:
   print("Dinero insufuciente")