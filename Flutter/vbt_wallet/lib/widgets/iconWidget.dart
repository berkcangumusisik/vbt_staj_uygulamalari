import 'package:flutter/cupertino.dart';
import 'package:flutter/src/widgets/framework.dart';

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
        Container(
          width: 60,
          height: 60,
          decoration: BoxDecoration(
            color: color,
            borderRadius: BorderRadius.circular(40),
          ),
          child: child,
        ),
        SizedBox(height:MediaQuery.of(context).size.height*0.01);
      ],
    );
  }
}
