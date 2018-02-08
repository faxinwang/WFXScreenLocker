## 简介

我自己写的一个锁屏程序, 功能非常简单, 就只是简单的用一个无边框的半透明窗体当做顶层窗体,然后用线程钩子屏蔽掉一些常用的热键以达到锁屏的目的, 还可以做一些简单的自定义设置, 锁屏界面的半透明窗体会在自定义的透明程度范围内不断变化, 有点像呼吸灯的感觉.

## 使用方法:

整个软件只有一个 **WFXScreenLocker.exe**  可执行程序,将该文件放到某一个目录下,然后直接双击运行即可, 无需安装. 首次运行该程序, 由于当前目录下没有配置文件, 程序会自动生成一个配置文件ScreenLocker.ini,里面保存了用户对程序的自定义设置.并提示

>您是第一次运行该程序!
>初始解锁秘密为 : author_wfx 
>请牢记!

`author_wfx`为初始解锁屏幕的密码, 过后可以自行修改.

还可以自定义锁屏界面的颜色和锁屏界面透明度的最大值和最小值, 通过对这两项的设置,可以调出不错的锁屏效果.

还有最重要的一点就是,需要把程序设置为自启动,不然一个重启或者注销就破解了

## 把程序设为自启动的方法:

1. 右键单击**WFXScreenLocker.exe**,点击创建快捷方式
2. 把创建的快捷方式链接拷贝到"启动"目录就OK了.

系统自启动目录(隐藏目录):
C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup

用户自启动目录:
C:\Users\ _YourUserName_ \AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup

>提示：快捷方式放到系统自启动目录时,任何用户登录系统时程序都会自启动,放在用户自启动目录时,相应的用户登录系统时, 程序才会自启动.

也许有人会说, windows本来就可以设置开机密码和唤醒屏幕的秘密, 我要这个干嘛! 额, 我本人觉得这个锁屏的半透明效果我很喜欢, 其次, windows的开机密码是可以通过BIOS擦除的, 我电脑就被我室友这样搞过, 我曾经也以为设置了开机秘密电脑就很安全了, 那次之后我就不这么认为了.
而这个锁屏程序, 只要将其设置为开机自启动,那么开机之后就会自动锁屏, 因为这不是系统程序, 所以无法通过BIOS来破解, 也没有其他破解的方法, 唯一的方法就是输入正确的解锁秘密! 现在是不是感觉电脑安全一些了呢.

需要看源代码的可以用Visual studio2015打开工程文件, 不需要源码的只需保留exe可执行程序就可以了

## 截图

![main](https://github.com/faxinwang/WFXScreenLocker/raw/master/imgs/main.png '主界面')

![opacity30](https://github.com/faxinwang/WFXScreenLocker/raw/master/imgs/opacity30.png '百分之30的透明度')

![opacity80](https://github.com/faxinwang/WFXScreenLocker/raw/master/imgs/opacity80.png '百分之80的透明度')

![notPass1](https://github.com/faxinwang/WFXScreenLocker/raw/master/imgs/notPass1.png '输入密码错误1')

![notPass2](https://github.com/faxinwang/WFXScreenLocker/raw/master/imgs/notPass2.png '输入密码错误2')

![changePassword](https://github.com/faxinwang/WFXScreenLocker/raw/master/imgs/changePassword.png '修改解锁密码')

![changeColor](https://github.com/faxinwang/WFXScreenLocker/raw/master/imgs/changeColor.png '修改锁屏颜色')

![changeOpacity](https://github.com/faxinwang/WFXScreenLocker/raw/master/imgs/changeOpacity.png '修改锁屏窗体透明度')