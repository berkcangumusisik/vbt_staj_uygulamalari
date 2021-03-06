import 'package:flutter/material.dart';
import 'package:vbt_wallet/animation/fadeAnimation.dart';

class IconWidget extends StatelessWidget {
  final String title;
  final Widget child;
  final double delayanimation;
  final Color color;
  const IconWidget(
      {super.key,
      required this.title,
      required this.child,
      required this.delayanimation,
      required this.color});

  @override
  Widget build(BuildContext context) {
    return Column(
      children: [
        FadeAnimation(
          delay: delayanimation,
          child: Container(
            width: 60,
            height: 60,
            decoration: BoxDecoration(
              color: color,
              borderRadius: BorderRadius.circular(40),
            ),
            child: child,
          ),
        ),
        SizedBox(
          height: MediaQuery.of(context).size.height * 0.01,
        ),
        FadeAnimation(
          delay: delayanimation,
          child: Text(
            title,
            style: const TextStyle(
              color: Colors.grey,
            ),
          ),
        ),
      ],
    );
  }
}
