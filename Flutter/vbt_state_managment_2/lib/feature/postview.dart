import 'package:flutter/material.dart';
import 'package:flutter/src/foundation/key.dart';
import 'package:flutter/src/widgets/framework.dart';
import 'package:vbtsummerstatemangement/feature/model/poat_model.dart';
import 'package:vbtsummerstatemangement/feature/service/post_service.dart';

class PostPage extends StatefulWidget {
  const PostPage({Key? key}) : super(key: key);

  @override
  State<PostPage> createState() => _PostPageState();
}

class _PostPageState extends State<PostPage> {
  final PostService _postService = PostService();
  List<PostModel>? _postmodel;
  bool isLoading = false;

  void changeLoading() {
    setState(() {
      isLoading = !isLoading;
    });
  }

  Future<void> init() async {
    _postmodel = await _postService.fetchPost();
    changeLoading();
  }

  @override
  void initState() {
    init();
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(),
      floatingActionButton: FloatingActionButton(
        onPressed: () {
          init();
        },
        child: Icon(Icons.star),
      ),
      body: isLoading
          ? ListView.builder(
              itemCount: _postmodel?.length,
              itemBuilder: (BuildContext context, int index) {
                return Card(
                  child: ListTile(
                    subtitle: Text(_postmodel?[index].title ?? 'data gelmemiştir'),
                    title: Text(_postmodel?[index].body ?? 'data gelmemiştir'),
                    leading: Text(_postmodel?[index].id.toString() ?? 'data gelmemiştir'),
                  ),
                );
              })
          : SizedBox(),
    );
  }
}
