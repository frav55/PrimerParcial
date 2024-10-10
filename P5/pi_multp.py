import math
import multiprocessing
from multiprocessing import Pool

def srinivasa_ramanujan_pi(n):
    suma=0
    for i in range(int(n)):
      # print (i)
      suma+=((math.factorial(4*i))*(1103+(26390*i))/(pow(math.factorial(i),4)*pow(396,4*i)))
    return (((2*math.sqrt(2))/9801)*suma)


if __name__=='__main__':
    
    np = 3
    print ('You have {0:1d} CPUs'.format(np))

    n = 1000000

    part_count = [n/np] * np
    pool = Pool(processes=np)   

    count=pool.map(srinivasa_ramanujan_pi, part_count, chunksize=n)

    print ("Esitmated value of Pi:: ", count)