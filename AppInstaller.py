#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Jun 21 20:14:25 2021

@author: agnishasingh
"""

from urllib import request
import subprocess as sp
from pathlib import Path
import time
import os
#for windows
#import pywinauto

DOWNLOAD_URL = "https://cloud.bluestacks.com/api/getdownloadnow?platform=mac&win_version=&mac_version=&client_uuid=11e0efd7-55a6-43d3-875a-203891fce382&app_pkg=&platform_cloud=%257B%2522description%2522%253A%2522Chrome%252090.0.4430.212%2520on%2520OS%2520X%252010.15.6%252064-bit%2522%252C%2522layout%2522%253A%2522Blink%2522%252C%2522manufacturer%2522%253Anull%252C%2522name%2522%253A%2522Chrome%2522%252C%2522prerelease%2522%253Anull%252C%2522product%2522%253Anull%252C%2522ua%2522%253A%2522Mozilla%252F5.0%2520(Macintosh%253B%2520Intel%2520Mac%2520OS%2520X%252010_15_6)%2520AppleWebKit%252F537.36%2520(KHTML%252C%2520like%2520Gecko)%2520Chrome%252F90.0.4430.212%2520Safari%252F537.36%2522%252C%2522version%2522%253A%252290.0.4430.212%2522%252C%2522os%2522%253A%257B%2522architecture%2522%253A64%252C%2522family%2522%253A%2522OS%2520X%2522%252C%2522version%2522%253A%252210.15.6%2522%257D%257D&preferred_lang=en&utm_source=Google&utm_medium=CPC&gaCookie=GA1.2.1390868582.1624203315&gclid=CjwKCAjwzruGBhBAEiwAUqMR8OZXFzvRCEwPhu-zTlSM0YyW1JejHOZ39ZVwlMSGJL4XY_2XhIRCeBoC09oQAvD_BwE&clickid=&msclkid=&affiliateId=&offerId=&transaction_id=&aff_sub=&first_landing_page=https%253A%252F%252Fwww.bluestacks.com%252Fbluestacks-5.html%253Futm_source%253DGoogle%2526utm_medium%253DCPC%2526utm_campaign%253Daw-ded-ww-tier3-eng-bluestacks5-brand%2526gclid%253DCjwKCAjwzruGBhBAEiwAUqMR8OZXFzvRCEwPhu-zTlSM0YyW1JejHOZ39ZVwlMSGJL4XY_2XhIRCeBoC09oQAvD_BwE&referrer=https%253A%252F%252Fwww.google.com%252F&download_page_referrer=&utm_campaign=aw-ded-ww-tier3-eng-bluestacks5-brand&exit_utm_campaign=download-page-dl-button-en&incompatible=false&bluestacks_version=bs4"
DOWNLOAD_DST = str(os.path.join(Path.home(), "Downloads", "app.dmg"))


def download(url, dst_file):
    try:
        content = request.urlopen(url).read()
        outfile = open(dst_file, "wb")
        outfile.write(content)
        outfile.close()
    except:
        print("An error occurred while downloading the set up.")


def install(prog):
    try:
        #opens installation dialog
        process = sp.Popen(prog, shell=True)
        process.wait()
        
        #for windows to get the installation window use pywinauto:
        """    
        app=Application.start(DOWNLOAD_DST, timeout=10)  
        installer_dlg=app.window("BlueStacks Installer")
        installer_dlg.Button.click_input(button='left', double=True)
        installer_dlg.Installer.click_input(button='left', double=False)
        """
        
        print("Setup has been successfully installed!")
    except:
        print("An error occurred in installation process")
    
    

def main():
    #check start time
    start_time = time.time()
    
    try:
        download(DOWNLOAD_URL, DOWNLOAD_DST)
    except:
        print("URL is incorrect")
        
    if (Path.exists(DOWNLOAD_DST)):
        install(DOWNLOAD_DST)
    else :  
       print ("Invalid destination folder")   
    
    #print execution time
    print("Time taken for execution:")
    print(time.time()-start_time())

if __name__ == "__main__":  
    main()