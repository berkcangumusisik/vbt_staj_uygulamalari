import 'package:flutter/material.dart';

class CustomBottomNavigationBar extends StatelessWidget {
  const CustomBottomNavigationBar({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      padding: const EdgeInsets.all(20),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceAround,
        children: [
          IconButton(
              onPressed: () {},
              icon: const Icon(
                Icons.home,
                color: Color(0xFFED648C),
                size: 30,
              )),
          IconButton(
              onPressed: () {},
              icon:
                  const Icon(Icons.insert_chart, color: Colors.grey, size: 30)),
          Container(
            width: 60,
            height: 60,
            decoration: BoxDecoration(
                borderRadius: BorderRadius.circular(30),
                color: const Color(0xFFED648C)),
            child: IconButton(
                onPressed: () {},
                icon: const Icon(Icons.qr_code_scanner,
                    color: Colors.white, size: 30)),
          ),
          IconButton(
              onPressed: () {},
              icon: const Icon(Icons.account_balance_wallet,
                  color: Colors.grey, size: 30)),
          IconButton(
              onPressed: () {},
              icon: const Icon(Icons.settings, color: Colors.grey, size: 30)),
        ],
      ),
    );
  }
}
