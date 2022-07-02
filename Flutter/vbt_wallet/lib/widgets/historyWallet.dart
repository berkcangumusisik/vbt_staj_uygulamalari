import 'package:flutter/material.dart';
import 'package:vbt_wallet/animation/fadeAnimation.dart';

class HistoryWallet extends StatelessWidget {
  final String title;
  final String image;
  final String day;
  final String time;
  final String money;
  final bool isPositive;
  const HistoryWallet(
      {super.key,
      required this.title,
      required this.image,
      required this.day,
      required this.time,
      required this.money,
      required this.isPositive});

  @override
  Widget build(BuildContext context) {
    return FadeAnimation(
      delay: 2,
      child: Container(
        width: MediaQuery.of(context).size.width * 0.9,
        height: MediaQuery.of(context).size.height * 0.085,
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(18),
          color: const Color(0xFF282A40),
        ),
        child: Row(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            CircleAvatar(
              backgroundImage: NetworkImage(image),
            ),
            SizedBox(
              width: MediaQuery.of(context).size.width * 0.035,
            ),
            Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text(
                  title,
                  style: const TextStyle(
                    color: Colors.white,
                  ),
                ),
                Row(
                  children: [
                    Text(
                      time,
                      style: const TextStyle(color: Colors.white),
                    ),
                    Text(
                      day,
                      style: const TextStyle(color: Colors.white),
                    ),
                  ],
                )
              ],
            ),
            SizedBox(
              width: MediaQuery.of(context).size.width * 0.16,
            ),
            Text(
              isPositive ? "+" : "-",
              style:
                  TextStyle(color: Colors.white, fontWeight: FontWeight.bold),
            ),
            Image.asset(
              "images/us-dollar.png",
              width: MediaQuery.of(context).size.width * 0.035,
              height: MediaQuery.of(context).size.height * 0.035,
              color: Colors.white,
            ),
            Text(
              money,
              style: const TextStyle(
                  color: Colors.white, fontWeight: FontWeight.bold),
            )
          ],
        ),
      ),
    );
  }
}
