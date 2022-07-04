import 'package:flutter/material.dart';
import 'package:vbtsummerstatemangement/feature/todo/service/todo_service.dart';

import 'model/todo_model.dart';

class TodoView extends StatefulWidget {
  TodoView({Key? key}) : super(key: key);

  @override
  State<TodoView> createState() => _TodoViewState();
}

class _TodoViewState extends State<TodoView> {
  ToDoService todo = ToDoService();
  ToDoModel? toDoModel;

  bool isLoading = false;
  void changeLoading() {
    setState(() {
      isLoading = !isLoading;
    });
  }

  Future<void> init() async {
    toDoModel = await todo.getToDo("3");
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
        appBar: AppBar(
          title: Text(
            'ToDo ',
            style: TextStyle(color: Colors.white, fontSize: 20),
          ),
        ),
        body: isLoading
            ? Center(
                child: Card(
                  child: Text(toDoModel?.title ?? "boştur"),
                ),
              )
            : Center(child: LinearProgressIndicator()));
  }
}
