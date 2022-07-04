// import 'package:flutter_test/flutter_test.dart';
// import 'package:pretty_dio_logger/pretty_dio_logger.dart';
// import 'package:vbtsummerstatemangement/feature/model/poat_model.dart';
// import 'package:vexana/vexana.dart';

// void main() {
//   INetworkManager? manager;
//   setUp(() {
//     const String baseUrl = 'https://jsonplaceholder.typicode.com/posts?userId=1';
//     manager = NetworkManager(options: BaseOptions(baseUrl: baseUrl));
//     manager?.dioIntercaptors.add(PrettyDioLogger());
//   });
//   test('Post Service Test', () async {
//     final response =
//         await manager?.send<PostModel, List<PostModel>?>('', parseModel: PostModel(), method: RequestType.GET);
//     print(response?.data);
//     expect(response, isNotNull);
//   });
// }
