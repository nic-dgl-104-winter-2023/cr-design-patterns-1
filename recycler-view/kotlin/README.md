# Kotlin RecyclerView example
The code in the recycler-view/kotlin folder is an excerpt from the Google Developers [Affirmations app](https://github.com/google-developer-training/android-basics-kotlin-affirmations-app-solution). This is not a complete runnable solution, but contains the key elements of the RecyclerView pattern as typically implemented in Android apps.

## Contents of this folder
- **Affirmation.kt**: The model for the app data.
- **Datasource.kt**: The data for the app. In this case the data is stored in the app in app code, rather than in an external database or file. As such, the data is immediately wrapped in a `List` of the model class, `Affirmation`. (This is atypical of most apps, but is sufficient for examining the structure of RecyclerView)
- **ItemAdapter**: The `ViewHolder` and `Adapter` classes, as required by RecyclerView.
- **list_item.xml**: The XML representation of the app views relevant to the RecyclerView and the `ViewHolder` class. The full implementation of the app includes a wrapped XML file with a UI RecyclerView that refers to the `list_item.xml`.
- **README.md**: This README file.