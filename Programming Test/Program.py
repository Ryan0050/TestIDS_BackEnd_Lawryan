satu,dua,tiga,empat, lima = (0,0,0,0,0)

for satu in range(11):
    if(satu%4 == 0):
        dua = dua + satu + tiga - lima
    if(satu%3 == 0):
        tiga = tiga + (satu+dua) - empat
    if(satu%2 == 0):
        empat = empat+(satu+dua)-tiga
    if(satu%1 == 0):
        lima = satu+dua+tiga

    print(f"iterasi {satu}")
    print(f'satu: {satu}')
    print(f'dua: {dua}')
    print(f'tiga: {tiga}')
    print(f'empat: {empat}')
    print(f'lima: {lima}')
    print("====================")