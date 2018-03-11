1) 改AutoBrowseWeb.exe.config 设置
			firefox.exe 的位置 T530 
            <setting name="Firefoxbin" serializeAs="String">
                <value>C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe</value>
            </setting>
			firefox.exe 的位置 T530 
			
			IdealPad的是 C:\\Program Files\\Mozilla Firefox\\firefox.exe
			
2） 值说明
            <setting name="page" serializeAs="String">
                <value>page.txt</value> /*具体的记录Page*/
				/*https://ramapi.kidshelpphone.ca/api/v2/resource/favour/json/9BB1408A-81DD-43D1-B621-83E2F71D2669/en/Both/13527785/1/1*/
            </setting>
            <setting name="cate" serializeAs="String">
                <value>pcategories.txt</value>  /*目录和子目录*/
				/* https://ramapi.kidshelpphone.ca/api/v2/resource/json/9BB1408A-81DD-43D1-B621-83E2F71D2669/en */
            </setting>
            <setting name="proxytime" serializeAs="String">
                <value>1</value>  /* 多少分钟换一次代理服务器IP */
            </setting>
            <setting name="times" serializeAs="String">
                <value>1</value>  /* 没有具体使用，被下面的间隔时间 代替了 */
            </setting>
            <setting name="proxies" serializeAs="String">
                <value>proxies.txt</value>     /* 代理服务器的IP和端口 66.70.255.195:3128 */
            </setting>
            <setting name="Iterval1" serializeAs="String">
                <value>2</value> /*第一个页面打开后间隔 分钟打开search 或，第二个页面*/
            </setting>
            <setting name="Iterval2" serializeAs="String">
                <value>3</value>
            </setting>
            <setting name="Iterval3" serializeAs="String">
                <value>3</value>
            </setting>
            <setting name="Iterval4" serializeAs="String">
                <value>2</value>
            </setting>
            <setting name="psearch" serializeAs="String">
                <value>psearch.txt</value>    /* 搜索的关键字    */
            </setting>