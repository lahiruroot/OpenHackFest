import subprocess

x=subprocess.run(["netsh","int","ip","reset"])
print(x)

y=subprocess.run(["netsh","winsock","reset"])
print(y)

z=subprocess.run(["ipconfig","/flushdns"])
print(z)

