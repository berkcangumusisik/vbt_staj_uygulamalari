import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/src/widgets/framework.dart';

class Home extends StatefulWidget {
  const Home({super.key});

  @override
  State<Home> createState() => _HomeState();
}

class _HomeState extends State<Home> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: const Color(0xFF181B2A),
      appBar: AppBar(
        backgroundColor: const Color(0xFF181B2A),
        elevation: 0,
        actions: [
          Row(
            children: [
              Column(
                children: const [
                  Text(
                    "Welcome back",
                    style: TextStyle(color: Colors.grey),
                  ),
                  Text(
                    "VBT",
                    style: TextStyle(
                        color: Colors.white,
                        fontSize: 25,
                        fontWeight: FontWeight.bold),
                  ),
                ],
              ),
              Container(
                height: 50,
                width: 50,
                margin: const EdgeInsets.only(left: 200, right: 10),
                decoration: BoxDecoration(
                  borderRadius: BorderRadius.circular(30),
                  color: const Color(0xFF272A3F),
                ),
                child: Icon(Icons.person_outline, color: Colors.white),
              )
            ],
          )
        ],
      ),
      body: SingleChildScrollView(
        child: SafeArea(
          child: SizedBox(
            height: MediaQuery.of(context).size.height,
            width: MediaQuery.of(context).size.width,
            child: Column(
              children: [
                //Kartlar Listesi
                Row(
                  children: [
                    //Icon Widget
                    IconWidget(
                      title: "Send",
                      child: IconButton(
                        onPressed: () {},
                        icon: Icon(Icons.send),
                        color: Colors.blue,
                      ),
                      delayAnimation: 1.7,
                      color: const Color(0xFF411C2E),
                    ),
                    IconWidget(
                      title: "Send",
                      child: IconButton(
                        onPressed: () {},
                        icon: Icon(Icons.send),
                        color: Colors.blue,
                      ),
                      delayAnimation: 1.7,
                      color: const Color(0xFF411C2E),
                    ),
                    IconWidget(
                      title: "Send",
                      child: IconButton(
                        onPressed: () {},
                        icon: Icon(Icons.send),
                        color: Colors.blue,
                      ),
                      delayAnimation: 1.7,
                      color: const Color(0xFF411C2E),
                    ),
                  ],
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}

/**
 * SingChildScrollView: Aşağı doğru kaydırılabilir özellik sağlar. Mesela Login ekranında input a tıklanıp klayve açılınca pixel kaymasını önler. physical özelliğini scroll edilemez özelliği de eklenebilir.
 * SizedBox: Boşluk oluşturmayı sağlar.
 * 
 */
